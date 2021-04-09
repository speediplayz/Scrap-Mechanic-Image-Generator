using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SMBlueprint
{
    class Blueprint
    {
        string path, name;
        string _UUID;
        public int blocks = 0;
        StreamWriter writerBlueprint;
        StreamWriter writerDescription;

        public Blueprint(string location, string name)
        {
            this.path = location;
            this.name = name;

            _UUID = Guid.NewGuid().ToString();

            Directory.CreateDirectory(location + "\\" + _UUID);

            writerBlueprint = new StreamWriter(location + "\\" + _UUID + @"\blueprint.json");
            writerDescription = new StreamWriter(location +"\\" +  _UUID + @"\description.json");

            writerBlueprint.WriteLine("{");
            writerBlueprint.WriteLine("   \"bodies\":[");
            writerBlueprint.WriteLine("      {");
            writerBlueprint.WriteLine("         \"childs\":[");

            writerDescription.WriteLine("{");
            writerDescription.WriteLine("   \"description\" : \"#{STEAM_WORKSHOP_NO_DESCRIPTION}\",");
            writerDescription.WriteLine("   \"localId\" : \"" + _UUID + "\",");
            writerDescription.WriteLine("   \"name\" : \"" + name + "\",");
            writerDescription.WriteLine("   \"type\" : \"Blueprint\",");
            writerDescription.WriteLine("   \"version\" : 0");
            writerDescription.WriteLine("}");
        }

        public int Count()
        {
            return blocks;
        }

        public void closeFile()
        {
            writerBlueprint.WriteLine("");
            writerBlueprint.WriteLine("         ]");
            writerBlueprint.WriteLine("      }");
            writerBlueprint.WriteLine("   ],");
            writerBlueprint.WriteLine("   \"version\":3");
            writerBlueprint.WriteLine("}");

            writerBlueprint.Flush();
            writerDescription.Flush();

            writerBlueprint.Dispose();
            writerDescription.Dispose();
        }

        public void addBlock(Block block, int x, int y, int z, string color)
        {
            string uuid = block.ToUUIDString();
            if(blocks > 0)
            {
                writerBlueprint.WriteLine(",");
            }
            writerBlueprint.WriteLine("            {");
            writerBlueprint.WriteLine("               \"bounds\":{");
            writerBlueprint.WriteLine("                  \"x\":1,");
            writerBlueprint.WriteLine("                  \"y\":1,");
            writerBlueprint.WriteLine("                  \"z\":1");
            writerBlueprint.WriteLine("               },");
            writerBlueprint.WriteLine("               \"color\":\"" + color + "\",");
            writerBlueprint.WriteLine("               \"pos\":{ ");
            writerBlueprint.WriteLine("                  \"x\":" + x + ",");
            writerBlueprint.WriteLine("                  \"y\":" + y + ",");
            writerBlueprint.WriteLine("                  \"z\":" + z + "");
            writerBlueprint.WriteLine("               },");
            writerBlueprint.WriteLine("               \"shapeId\":\"" + uuid + "\",");
            writerBlueprint.WriteLine("               \"xaxis\":1,");
            writerBlueprint.WriteLine("               \"zaxis\":3");
            writerBlueprint.Write("            }");
            blocks++;
        }
    }

    public enum Block
    {
        SCRAP_WOOD_BLOCK,
		WOOD_BLOCK_1,
        WOOD_BLOCK_2,
        WOOD_BLOCK_3,
        SCRAP_METAL_BLOCK,
        METAL_BLOCK_2,
        METAL_BLOCK_3,
        SCRAP_STONE_BLOCK,
        CRACKED_STONE_BLOCK,
        CONCRETE_SLAB_BLOCK,
        CONCRETE_BLOCK_1,
        CONCRETE_BLOCK_2,
        CONCRETE_BLOCK_3,
        RUSTED_METAL_BLOCK,
        EXTRUDED_METAL_BLOCK,
        SOLID_METAL_BLOCK,
        ALUMINUM_BLOCK,
        NET_BLOCK,
        SPACESHIP_FLOOR_BLOCK,
        PLASTIC_BLOCK,
        RESTROOM_BLOCK,
        INSULATION_BLOCK,
        STRIPED_NET_BLOCK,
        PLASTER_BLOCK,
        SQUARE_MESH_BLOCK,
        ARMORED_GLASS_BLOCK,
        FRAMEWORK_BLOCK,
        SAND_BLOCK,
        WORN_METAL_BLOCK,
        PAINTED_WALL_BLOCK,
        PUNCHED_STEEl_BLOCK,
        BUBBLE_PLASTIC_BLOCK,
        DIAMOND_PLATE_BLOCK,
        CARPET_BLOCK
    }

    public static partial class BlockMethods
    {
        public static string ColorToString(Color c)
        {
            return c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        public static string ToUUIDString(this Block b)
        {
            string result = "1897ee42-0291-43e4-9645-8c5a5d310398";

            switch (b)
            {
                case Block.SCRAP_WOOD_BLOCK:
                    result = "1fc74a28-addb-451a-878d-c3c605d63811";
                    break;
				case Block.WOOD_BLOCK_1:
					result = "df953d9c-234f-4ac2-af5e-f0490b223e71";
					break;
                case Block.WOOD_BLOCK_2:
                    result = "1897ee42-0291-43e4-9645-8c5a5d310398";
                    break;
                case Block.WOOD_BLOCK_3:
                    result = "061b5d4b-0a6a-4212-b0ae-9e9681f1cbfb";
                    break;
                case Block.SCRAP_METAL_BLOCK:
                    result = "1f7ac0bb-ad45-4246-9817-59bdf7f7ab39";
                    break;
                case Block.METAL_BLOCK_2:
                    result = "1016cafc-9f6b-40c9-8713-9019d399783f";
                    break;
                case Block.METAL_BLOCK_3:
                    result = "c0dfdea5-a39d-433a-b94a-299345a5df46";
                    break;
                case Block.SCRAP_STONE_BLOCK:
                    result = "30a2288b-e88e-4a92-a916-1edbfc2b2dac";
                    break;
                case Block.CRACKED_STONE_BLOCK:
                    result = "f5ceb7e3-5576-41d2-82d2-29860cf6e20e";
                    break;
                case Block.CONCRETE_SLAB_BLOCK:
                    result = "cd0eff89-b693-40ee-bd4c-3500b23df44e";
                    break;
                case Block.CONCRETE_BLOCK_1:
                    result = "a6c6ce30-dd47-4587-b475-085d55c6a3b4";
                    break;
                case Block.CONCRETE_BLOCK_2:
                    result = "ff234e42-5da4-43cc-8893-940547c97882";
                    break;
                case Block.CONCRETE_BLOCK_3:
                    result = "e281599c-2343-4c86-886e-b2c1444e8810";
                    break;
                case Block.RUSTED_METAL_BLOCK:
                    result = "220b201e-aa40-4995-96c8-e6007af160de";
                    break;
                case Block.EXTRUDED_METAL_BLOCK:
                    result = "25a5ffe7-11b1-4d3e-8d7a-48129cbaf05e";
                    break;
                case Block.SOLID_METAL_BLOCK:
                    result = "3d0b7a6e-5b40-474c-bbaf-efaa54890e6a";
                    break;
                case Block.ALUMINUM_BLOCK:
                    result = "3e3242e4-1791-4f70-8d1d-0ae9ba3ee94c";
                    break;
                case Block.NET_BLOCK:
                    result = "4aa2a6f0-65a4-42e3-bf96-7dec62570e0b";
                    break;
                case Block.SPACESHIP_FLOOR_BLOCK:
                    result = "4ad97d49-c8a5-47f3-ace3-d56ba3affe50";
                    break;
                case Block.PLASTIC_BLOCK:
                    result = "628b2d61-5ceb-43e9-8334-a4135566df7a";
                    break;
                case Block.RESTROOM_BLOCK:
                    result = "920b40c8-6dfc-42e7-84e1-d7e7e73128f6";
                    break;
                case Block.INSULATION_BLOCK:
                    result = "9be6047c-3d44-44db-b4b9-9bcf8a9aab20";
                    break;
                case Block.STRIPED_NET_BLOCK:
                    result = "a479066d-4b03-46b5-8437-e99fec3f43ee";
                    break;
                case Block.PLASTER_BLOCK:
                    result = "b145d9ae-4966-4af6-9497-8fca33f9aee3";
                    break;
                case Block.SQUARE_MESH_BLOCK:
                    result = "b4fa180c-2111-4339-b6fd-aed900b57093";
                    break;
                case Block.ARMORED_GLASS_BLOCK:
                    result = "b5ee5539-75a2-4fef-873b-ef7c9398b3f5";
                    break;
                case Block.FRAMEWORK_BLOCK:
                    result = "c4a2ffa8-c245-41fb-9496-966c6ee4648b";
                    break;
                case Block.SAND_BLOCK:
                    result = "c56700d9-bbe5-4b17-95ed-cef05bd8be1b";
                    break;
                case Block.WORN_METAL_BLOCK:
                    result = "d740a27d-cc0f-4866-9e07-6a5c516ad719";
                    break;
                case Block.PAINTED_WALL_BLOCK:
                    result = "e981c337-1c8a-449c-8602-1dd990cbba3a";
                    break;
                case Block.PUNCHED_STEEl_BLOCK:
                    result = "ea6864db-bb4f-4a89-b9ec-977849b6713a";
                    break;
                case Block.BUBBLE_PLASTIC_BLOCK:
                    result = "f406bf6e-9fd5-4aa0-97c1-0b3c2118198e";
                    break;
                case Block.DIAMOND_PLATE_BLOCK:
                    result = "f7d4bfed-1093-49b9-be32-394c872a1ef4";
                    break;
                case Block.CARPET_BLOCK:
                    result = "febce8a6-6c05-4e5d-803b-dfa930286944";
                    break;
            }

            return result;
        }
    }
}
