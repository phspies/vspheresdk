using System.Linq;
using System.Threading.Tasks;
using vspheresdk;
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
            //var templates = await vsphere.VcenterSubModule.VmTemplateLibraryItemsModule.(clusters[0].Cluster);
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
                        Shares = new vspheresdk.Vcenter.Models.VcenterResourcePoolSharesInfoType()
                        {
                            Level = VcenterResourcePoolSharesInfoLevelType.NORMAL
                        }
                    },
                    MemoryAllocation = new VcenterResourcePoolResourceAllocationCreateSpecType()
                    {
                        ExpandableReservation = true,
                        Limit = 50,
                        Reservation = 0,
                        Shares = new vspheresdk.Vcenter.Models.VcenterResourcePoolSharesInfoType()
                        {
                            Level = VcenterResourcePoolSharesInfoLevelType.NORMAL
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
                         Shares = new vspheresdk.Vcenter.Models.VcenterResourcePoolSharesInfoType()
                         {
                             Level = VcenterResourcePoolSharesInfoLevelType.NORMAL
                         }
                     },
                     MemoryAllocation = new VcenterResourcePoolResourceAllocationCreateSpecType()
                     {
                         ExpandableReservation = true,
                         Limit = 50,
                         Reservation = 0,
                         Shares = new vspheresdk.Vcenter.Models.VcenterResourcePoolSharesInfoType()
                         {
                             Level = VcenterResourcePoolSharesInfoLevelType.NORMAL
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


            var createVM = await vsphere.VcenterSubModule.GuestCustomizationSpecsModule.CreateAsync(new VcenterGuestCustomizationSpecsCreateType()
            {
                Name = "TestCodeCustomization",
                Spec = new VcenterGuestCustomizationSpecType()
                {
                    ConfigurationSpec = new VcenterGuestConfigurationSpecType()
                    {
                        CloudConfig = new vspheresdk.Vcenter.Models.VcenterGuestCloudConfigurationType()
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

            //await vsphere.VcenterSubModule.VMModule.CloneAsync(new VcenterVmcloneType()
            //{
            //    GuestCustomizationSpec = new VcenterVmguestCustomizationSpecType()
            //    {
            //        Name = "TestCodeCustomization"
            //    },
            //     Source = 
            //});

            await vsphere.LogoutAsync();



        }
    }
}