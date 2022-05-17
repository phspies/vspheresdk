using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vspheresdk;
using vspheresdk.Library.Models;
using vspheresdk.Library.Models.Enums;
using vspheresdk.Vcenter.Models;
using vspheresdk.Vcenter.Models.Enums;
using Xunit;

namespace vSphereSDKTesting
{
    public class BasicTest
    {
        [Fact]
        public async void Test1()
        {
            vSphereClient vsphere = new vSphereClient("vc01.lab.local", "administrator@vsphere.local", "VMware1!", false);
            await vsphere.LoginAsync();
            var vms = await vsphere.VcenterSubModule.VMModule.ListAsync();
            var clusters = await vsphere.VcenterSubModule.ClusterModule.ListAsync();
            var libids = await vsphere.LibrarySubModule.LibraryModule.ListAsync();
            List<ContentLibraryModelType> libs = new List<ContentLibraryModelType>();
            foreach (string id in libids)
            {
                libs.Add(await vsphere.LibrarySubModule.LibraryModule.GetAsync(id));
            }
            var testvm = await vsphere.VcenterSubModule.VMModule.GetAsync(vms[0].Vm);

            var resourcepools = await vsphere.VcenterSubModule.ResourcePoolModule.ListAsync();
            var rpdetails = await vsphere.VcenterSubModule.ResourcePoolModule.GetAsync(resourcepools[0].ResourcePool);

            //create base resource pool
            var createrp = await vsphere.VcenterSubModule.ResourcePoolModule.CreateAsync(
                new VcenterResourcePoolCreateType()
                {
                    Parent = resourcepools[0].ResourcePool,
                    Name = "TestCodeResourcePool",
                    CpuAllocation = new VcenterResourcePoolResourceAllocationCreateSpecType()
                    {
                        ExpandableReservation = true,
                        Limit = 300,
                        Reservation = 0,
                        Shares = new VcenterResourcePoolSharesInfoType()
                        {
                            Level = VcenterResourcePoolSharesInfoLevelEnumType.NORMAL
                        }
                    },
                    MemoryAllocation = new VcenterResourcePoolResourceAllocationCreateSpecType()
                    {
                        ExpandableReservation = true,
                        Limit = 50,
                        Reservation = 0,
                        Shares = new VcenterResourcePoolSharesInfoType()
                        {
                            Level = VcenterResourcePoolSharesInfoLevelEnumType.NORMAL
                        }
                    }
                }
            );
            Assert.NotNull(createrp);

            //create nested resource pool
            var createrp2 = await vsphere.VcenterSubModule.ResourcePoolModule.CreateAsync(
                 new VcenterResourcePoolCreateType()
                 {
                     Parent = createrp,
                     Name = "NestedTestCodeResourcePool",
                     CpuAllocation = new VcenterResourcePoolResourceAllocationCreateSpecType()
                     {
                         ExpandableReservation = true,
                         Limit = 300,
                         Reservation = 0,
                         Shares = new VcenterResourcePoolSharesInfoType()
                         {
                             Level = VcenterResourcePoolSharesInfoLevelEnumType.NORMAL
                         }
                     },
                     MemoryAllocation = new VcenterResourcePoolResourceAllocationCreateSpecType()
                     {
                         ExpandableReservation = true,
                         Limit = 50,
                         Reservation = 0,
                         Shares = new VcenterResourcePoolSharesInfoType()
                         {
                             Level = VcenterResourcePoolSharesInfoLevelEnumType.NORMAL
                         }
                     }
                 }
             );
            Assert.NotNull(createrp2);

            await Task.Delay(10000);
            //delete nested resource pools
            await vsphere.VcenterSubModule.ResourcePoolModule.DeleteAsync(createrp);

            var networkList = await vsphere.VcenterSubModule.NetworkModule.ListAsync();
            var hostList = await vsphere.VcenterSubModule.HostModule.ListAsync();

            
            var createCustSpec = await vsphere.VcenterSubModule.GuestCustomizationSpecsModule.CreateAsync(new VcenterGuestCustomizationSpecsCreateType()
            {
                Name = "TestCodeCustomization",
                Spec = new VcenterGuestCustomizationSpecType()
                {
                    Interfaces = new Dictionary<string, VcenterGuestAdapterMappingType>() {
                        {
                            "2000", new VcenterGuestAdapterMappingType() {
                                Adapter = new VcenterGuestIpsettingsType()
                                {
                                    Ipv4 = new VcenterGuestIpv4Type()
                                    {
                                         IpAddress = "10.200.0.10",
                                         Prefix = 24,
                                         Gateways = new List<string>() { "10.0.0.1" },
                                         Type = VcenterGuestIpv4TypeEnum.STATIC
                                    },
                                    Windows = new VcenterGuestWindowsNetworkAdapterSettingsType()
                                    {

                                    }

                                }

                            }
                        }
                    },
                    ConfigurationSpec = new VcenterGuestConfigurationSpecType()
                    {
                        CloudConfig = new VcenterGuestCloudConfigurationType()
                        {
                            Cloudinit = new VcenterGuestCloudinitConfigurationType()
                            {
                                Metadata = "",
                                Userdata = ""
                            }
                        }
                    }
                }
            });



            string deployedVM = await vsphere.VcenterSubModule.VmTemplateLibraryItemsModule.DeployAsync("item", new VcenterVmTemplateLibraryItemsDeployType()
            {
                Name = "testdeployVM",
                Description = "Test deployment VM for SDK",
                Placement = new VcenterVmTemplateLibraryItemsDeployPlacementSpecType()
                {
                    Cluster = "cluster",
                    ResourcePool = "ResourcePool"
                },
                DiskStorage = new VcenterVmTemplateLibraryItemsDeploySpecDiskStorageType()
                {
                    Datastore = "datastorename",
                    StoragePolicy = new VcenterVmTemplateLibraryItemsDeploySpecDiskStoragePolicyType()
                    {
                        Policy = "policyname",
                        Type = VcenterVmTemplateLibraryItemsDeploySpecDiskStoragePolicyTypeEnum.USESPECIFIEDPOLICY
                    }
                },
                GuestCustomization = new VcenterVmTemplateLibraryItemsGuestCustomizationSpecType()
                {
                    Name = "customizationspecname"
                },
                PoweredOn = true,
                HardwareCustomization = new VcenterVmTemplateLibraryItemsHardwareCustomizationSpecType()
                {
                    CpuUpdate = new VcenterVmTemplateLibraryItemsCpuUpdateSpecType()
                    {
                        NumCoresPerSocket = 1,
                        NumCpus = 1
                    },
                    MemoryUpdate = new VcenterVmTemplateLibraryItemsMemoryUpdateSpecType()
                    {
                        Memory = 4096
                    },
                    Nics = new Dictionary<string, VcenterVmTemplateLibraryItemsEthernetUpdateSpecType>()
                       {
                           {
                               "200",
                               new VcenterVmTemplateLibraryItemsEthernetUpdateSpecType()
                               {
                                    Network = "network"
                               }
                           }
                       }
                }
            });
            string clonedVM = await vsphere.VcenterSubModule.VMModule.CloneAsync(new VcenterVmcloneType()
            {
                GuestCustomizationSpec = new VcenterVmguestCustomizationSpecType()
                {
                    Name = "TestCodeCustomization"
                },
                Source = "test",
                Placement = new VcenterVmclonePlacementSpecType()
                {
                    Cluster = "Cluster",
                    Datastore = "datastore",
                    ResourcePool = "resource pool"
                },
                Name = "Name",

            });

            await vsphere.LogoutAsync();



        }
    }
}