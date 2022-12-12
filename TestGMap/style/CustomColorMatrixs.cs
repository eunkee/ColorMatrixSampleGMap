using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGMap.style
{
    public class CustomColorMatrixs
    {
        public static readonly ColorMatrix GrayScale = new ColorMatrix(new[]
        {
            new float[] {.3f, .3f, .3f, 0, 0},
            new float[] {.59f, .59f, .59f, 0, 0},
            new float[] {.11f, .11f, .11f, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1}
        });

        public static readonly ColorMatrix Default = new ColorMatrix(new[]
{
            new float[] {1, 0, 0, 0, 0},
            new float[] {0, 1, 0, 0, 0},
            new float[] {0, 0, 1, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1}
        });

        public static readonly ColorMatrix Negative = new ColorMatrix(new[]
        {
            new float[] {-1, 0, 0, 0, 0},
            new float[] {0, -1, 0, 0, 0},
            new float[] {0, 0, -1, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {1, 1, 1, 0, 1}
        });


        public static readonly ColorMatrix Case1 = new ColorMatrix(new[]
        {
            new float[] {0.7f, 0.3f, 1.1f, -0.3f, 0.0f},
            new float[] {-1.6f, 0.5f, -2.0f, -2.0f, 0.3f},
            new float[] {0.0f, 0.5f, 0.9f, 0.8f, 0.0f},
            new float[] {0.0f, -0.7f, -0.0f, 0.8f, 0.0f},
            new float[] {-0.1f, -0.3f, 0.2f, 0.9f, 0.0f }
        });

        public static readonly ColorMatrix Case2 = new ColorMatrix(new[]
        {
            new float[] {0.7f, 0.05f, -1.0f, -1.1f, 0.0f},
            new float[] {0.0f, 0.0f, 1.84f, 0.1f, 0.0f},
            new float[] {0.2f, 0.05f, 0.44f, 0.0f, 0.0f},
            new float[] {1.0f, 0.05f, -0.5f, 0.5f, 0.0f},
            new float[] {-2.0f, -0.1f, -0.65f, 1.0f, 0.0f }
        });

        public static readonly ColorMatrix Case3 = new ColorMatrix(new[]
        {
            new float[] {0.0f, 0.3f, 0.85f, 0.0f, 0.0f},
            new float[] {0.0f, 0.35f, 0.35f, 0.0f, 0.0f},
            new float[] {-1.0f, -0.9f, -0.9f, 0.0f, 0.0f},
            new float[] {0.45f, 0.44f, -0.28f, 1.0f, 0.0f},
            new float[] {0.3f, 0.01f, 0.3f, 1.0f, 0.0f }
        });

    }

    public enum MATRIXS_LIST
    {
        CASE1,
        CASE2,
        CASE3,
        GRAY_SCALE,
        NEGATIVE,
        DEFAULT
    }

    public enum MAP_SERVICE_LIST
    {
        GOOGLE,
        GOOGLE_RASTER,
        BING,
        BING_RASTER,
        OPEN_STREET_MAP
    }

}
