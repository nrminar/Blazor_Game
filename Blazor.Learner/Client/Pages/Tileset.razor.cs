using Microsoft.AspNetCore.Components;

namespace Blazor.Learner.Client.Pages
{
    public class TilesetBase : ComponentBase
    {
        public Ground Background = new Ground(5, 5);
    }
    public class Ground
    {
        public Tile[][] groundMap { get; set; }

        public Ground(int depth, int length)
        {
            this.groundMap = new Tile[depth][];
            for (int d = 0; d < depth; d++)
            {
                this.groundMap[d] = new Tile[length];
                for (int dd = 0; dd < length; dd++)
                {
                    this.groundMap[d][dd] = new Tile(0, d, dd);
                }
            }
        }
    }
    public class Tile
    {
        //[Inject]
        //private ImageMap { get; set; }
        public Tile(int type, int depth, int length)
        {
            int Type = type;
            int Depth = depth;
            int Lendth = length;
        }

        //public String getImage()
        //{
        //    return this.ImageMap[this.Type];
        //}
    }
}
