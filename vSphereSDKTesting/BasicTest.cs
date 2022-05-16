using vspheresdk;
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
            var testvm = await vsphere.VcenterSubModule.VMModule.GetAsync(vms[0].Vm);

            var resourcepools = await vsphere.VcenterSubModule.ResourcePoolModule.ListAsync();
            var rpdetails = await vsphere.VcenterSubModule.ResourcePoolModule.GetAsync(resourcepools[0].ResourcePool);

            var createrp = await vsphere.VcenterSubModule.ResourcePoolModule.CreateAsync(
                new vspheresdk.Vcenter.Models.VcenterResourcePoolCreateType()
                {
                    Parent = rpdetails.Name
                }
            );


            var testesx = await vsphere.VcenterSubModule.NetworkModule.ListAsync();
            var testesx2 = await vsphere.VcenterSubModule.HostModule.ListAsync();
        }
    }
}