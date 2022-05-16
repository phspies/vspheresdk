# C# SDK for vSphere 7.0.3

SDK compatable with .net 6.0 for vSphere 7.0.3 RestAPI engins. It uses RestSharp as the transport and Newtonsoft.Json for JSON handeling.

## Modules

All available modules are included:

```dotnet
vSphereClient vsphere = new vSphereClient("vc01.lab.local", "administrator@vsphere.local", "VMware1!", false);
await vsphere.LoginAsync();

var vms = await vsphere.VcenterSubModule.VMModule.ListAsync();
var testvm = await vsphere.VcenterSubModule.VMModule.GetAsync(vms[0].Vm);

var resourcepools = await vsphere.VcenterSubModule.ResourcePoolModule.ListAsync();
var rpdetails = await vsphere.VcenterSubModule.ResourcePoolModule.GetAsync(resourcepools[0].ResourcePool);

```

## Custom JsonSerializerSettings

You can pass your own serialization settings as part of the client init code

```dotnet
vSphereClient vsphere = new vSphereClient("vc01.lab.local", "administrator@vsphere.local", "VMware1!", false, new Newtonsoft.Json.JsonSerializerSettings() {  Formatting = Newtonsoft.Json.Formatting.None });

```

