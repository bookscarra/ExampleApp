using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeLogic
{
    public class BillOfMaterial
    {
        private List<BaseShapeClass> Materials;

        public BillOfMaterial()
        {
            Materials = new List<BaseShapeClass>();
        }

        public void AddShape(BaseShapeClass item)
        {
            Materials.Add(item);
        }

        /// <summary>
        /// Generate the bill of materials based on given input
        /// </summary>
        /// <returns></returns>
        public string GenerateBillOfMaterials()
        {
            Log.Information("Generate Bill Of Materials Called");

            if (Valid())
            {

                var bomContent = string.Format(Constants.BOM_FORMAT_STRING,
                                                string.Join("",
                                                        Materials.Select(m => m.ToString() + Environment.NewLine)));

                Log.Information($"Bill of Materials generated successfully with {Materials.Count} materials.");
                return bomContent;
            }
            else
            {
                Log.Error("An error has been encountered while trying to generate BOM. ABORT returned");
                return Constants.ABORT;
            }
        }

        public void Clear()
        {
            Materials.Clear();
        }

        private bool Valid()
        {
            foreach (var item in Materials)
            {
                if (!item.Valid())
                {
                    Log.Error($"Material {item} contains invalid values. Values must fall between 0-1000.");
                    return false;
                }
            }

            return true;
        }
    }
}
