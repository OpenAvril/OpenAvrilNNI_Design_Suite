
using System.ComponentModel;

namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class Global
    {
// definitions.
        public enum FILE_NAME : byte
        {
            [Description("OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1")]
            PRAISE_1 = 1,
        }
        public enum NodeLayer : byte
        {
            Layer_4 = 4,
            Layer_3 = 3,
            Layer_2 = 2,
            Layer_1 = 1,
            Layer_0 = 0,
        }
        public enum PraiseID : byte
        {
            Praise_1 = 1,
        }
        public enum PRAISE_1_I : byte
        {
        // linear.
            Mouse_Screen_X,
            Mouse_Screen_Y,
            Capsule_Fowards_X,
            Capsule_Fowards_Y,
            Capsule_Fowards_Z,
            Capsule_Right_X,
            Capsule_Right_Y,
            Capsule_Right_Z,
        // boolean.
        // constants.
            Capsule_Up_X,
            Capsule_Up_Y,
            Capsule_Up_Z,
        }
        public enum PRAISE_1_O : byte
        {
        // linear.
            Capsule_Fowards_X,
            Capsule_Fowards_Y,
            Capsule_Fowards_Z,
            Capsule_Right_X,
            Capsule_Right_Y,
            Capsule_Right_Z,
        // boolean.
        // constants.
            Mouse_Screen_X,
            Mouse_Screen_Y,
            Capsule_Up_X,
            Capsule_Up_Y,
            Capsule_Up_Z,
        }

// registers.

// constructor.
        public Global()
        {
            System.Console.WriteLine("entered Global.");
        }

// destructor
        ~Global()
        {
            //System.Console.WriteLine("exited Global.");
        }

// public.
    // get.
    // set.

// private.
    // get.
    // set.
    }
}
    
