using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vapi.Models.Enums;

namespace vspheresdk.Vapi.Models
{
    public class VapiMetadataMetamodelComponentDataTypeA 
    {
        /// <summary>
        /// Metamodel information of the component element. This includes information about all the package elements contained in
        /// this component element. <p> The metamodel information about a component could be quite large if there are a lot of
        /// package elements contained in this component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "info", Required = Required.AllowNull)]
        public VapiMetadataMetamodelComponentInfoTypeA Info { get; set; }
        /// <summary>
        /// Fingerprint of the metamodel metadata of the component component. <p> Metamodel information could change when there is
        /// an infrastructure update and new functionality is added to an existing component. <p> Since the data present in {@link
        /// ComponentData#info} could be quite large, {@name #fingerprint} provides a convenient way to check if the data for a
        /// particular component is updated. <p> You should store the fingerprint associated with a component. After an update, by
        /// invoking the {@link vapi.metadata.metamodel.Component#fingerprint} {@term operation}, you can retrieve the new
        /// fingerprint for the component. If the new fingerprint and the previously stored fingerprint do not match, clients can
        /// use the {@link vapi.metadata.metamodel.Component#get} to retrieve the new metamodel information for the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "fingerprint", Required = Required.AllowNull)]
        public string Fingerprint { get; set; }
    }
}
