using Newtonsoft.Json;
using System.Collections.Generic;

namespace RevitGltfExporter
{
    public class Mesh
    {
        [JsonIgnore]
        public int id { get; private set; }
        public List<Primitive> primitives => Gltf.Instance.primitivesOf(id);

        public Mesh(int id) { this.id = id; }
    }
}
