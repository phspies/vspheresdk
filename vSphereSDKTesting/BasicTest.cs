using Newtonsoft.Json;
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
            var templateimage = await vsphere.VcenterSubModule.VMModule.GetAsync(vms.Single(x => x.Name.Equals("ubuntutemplate")).Vm);
            var clusters = await vsphere.VcenterSubModule.ClusterModule.ListAsync();
            var cluster = clusters.Single(x => x.Name.Equals("BaseCluster01"));
            var datacenters = await vsphere.VcenterSubModule.DatacenterModule.ListAsync();
            var datacenter = await vsphere.VcenterSubModule.DatacenterModule.GetAsync(datacenters.First().Datacenter);
            var libids = await vsphere.LibrarySubModule.LibraryModule.ListAsync();
            List<ContentLibraryModelType> libs = new List<ContentLibraryModelType>();
            foreach (string id in libids)
            {
                libs.Add(await vsphere.LibrarySubModule.LibraryModule.GetAsync(id));
            }
            var templateid = await vsphere.LibrarySubModule.LibraryItemModule.ListAsync(libs.Single(x => x.Name == "Templates").Id);
            var template = await vsphere.LibrarySubModule.LibraryItemModule.GetAsync(templateid.First());
            var testvm = await vsphere.VcenterSubModule.VMModule.GetAsync(vms[0].Vm);

            var resourcepools = await vsphere.VcenterSubModule.ResourcePoolModule.ListAsync(Clusters: cluster.Cluster);
            var rpdetails = await vsphere.VcenterSubModule.ResourcePoolModule.GetAsync(resourcepools[0].ResourcePool);

            var networkList = await vsphere.VcenterSubModule.NetworkModule.ListAsync();
            var hostList = await vsphere.VcenterSubModule.HostModule.ListAsync();
            var clusterList = await vsphere.VcenterSubModule.ClusterModule.ListAsync();
            var datatoreList = await vsphere.VcenterSubModule.DatastoreModule.ListAsync();
            var storagepolicyList = await vsphere.VcenterSubModule.StoragePoliciesModule.ListAsync();


            var cloneVMObject = new VcenterVmTemplateLibraryItemsDeployType()
            {
                Name = "testdeployVM",
                Description = "Test deployment VM for SDK",
                Placement = new VcenterVmTemplateLibraryItemsDeployPlacementSpecType()
                {
                    Cluster = clusterList.Single(x => x.Name.Equals("BaseCluster01")).Cluster,
                    ResourcePool = resourcepools[0].ResourcePool,
                    Folder = datacenter.VmFolder
                },
                DiskStorage = new VcenterVmTemplateLibraryItemsDeploySpecDiskStorageType()
                {
                    Datastore = datatoreList.Single(x => x.Name.Equals("BaseCluster-datastore")).Datastore,
                    StoragePolicy = new VcenterVmTemplateLibraryItemsDeploySpecDiskStoragePolicyType()
                    {
                        Policy = storagepolicyList.Single(x => x.Name.Equals("Default TKG Storage Policy")).Policy,
                        Type = VcenterVmTemplateLibraryItemsDeploySpecDiskStoragePolicyTypeEnum.USESPECIFIEDPOLICY
                    }
                },
                PoweredOn = true,
                HardwareCustomization = new VcenterVmTemplateLibraryItemsHardwareCustomizationSpecType()
                {
                    CpuUpdate = new VcenterVmTemplateLibraryItemsCpuUpdateSpecType()
                    {
                        NumCoresPerSocket = 2,
                        NumCpus = 2
                    },
                    MemoryUpdate = new VcenterVmTemplateLibraryItemsMemoryUpdateSpecType()
                    {
                        Memory = 4096
                    },
                    Nics = new Dictionary<string, VcenterVmTemplateLibraryItemsEthernetUpdateSpecType>()
                    {
                        {
                            templateimage.Nics.First().Key,
                            new VcenterVmTemplateLibraryItemsEthernetUpdateSpecType()
                            {
                                Network = networkList.Single(x => x.Name.Equals("BaseNetwork")).Network
                            }
                        }
                    }
                }
            };

            var json = JsonConvert.SerializeObject(cloneVMObject, Formatting.Indented);

            string deployedVM = await vsphere.VcenterSubModule.VmTemplateLibraryItemsModule.DeployAsync(template.Id, cloneVMObject);


            await vsphere.VcenterSubModule.VmPowerModule.StopAsync(deployedVM);
            await vsphere.VcenterSubModule.VMModule.DeleteAsync(deployedVM);
            await vsphere.LogoutAsync();



            //var createCustSpec = await vsphere.VcenterSubModule.GuestCustomizationSpecsModule.CreateAsync(new VcenterGuestCustomizationSpecsCreateType()
            //{
            //    Name = "TestCodeCustomization",
            //    Spec = new VcenterGuestCustomizationSpecType()
            //    {
            //        Interfaces = new Dictionary<string, VcenterGuestAdapterMappingType>() {
            //            {
            //                "2000", new VcenterGuestAdapterMappingType() {
            //                    Adapter = new VcenterGuestIpsettingsType()
            //                    {
            //                        Ipv4 = new VcenterGuestIpv4Type()
            //                        {
            //                             IpAddress = "10.200.0.10",
            //                             Prefix = 24,
            //                             Gateways = new List<string>() { "10.0.0.1" },
            //                             Type = VcenterGuestIpv4TypeEnum.STATIC
            //                        },
            //                        Windows = new VcenterGuestWindowsNetworkAdapterSettingsType()
            //                        {

            //                        }

            //                    }

            //                }
            //            }
            //        },
            //        ConfigurationSpec = new VcenterGuestConfigurationSpecType()
            //        {
            //            CloudConfig = new VcenterGuestCloudConfigurationType()
            //            {
            //                Cloudinit = new VcenterGuestCloudinitConfigurationType()
            //                {
            //                    Metadata = "",
            //                    Userdata = ""
            //                }
            //            }
            //        }
            //    }
            //});

        }
    }
}