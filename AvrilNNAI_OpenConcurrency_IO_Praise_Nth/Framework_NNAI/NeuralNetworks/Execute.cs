
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Execute
    {
// classes.

// registers.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.FileReadWrite _FileReadWrite;

// constructor.
        public Execute()
        {
            //System.Console.WriteLine("entered Execute.");
            Create_FileReadWrite(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.FileReadWrite());
            while (Get_FileReadWrite() == null) { }
        }

// destructor.
        ~Execute()
        {

        }

// public.
        public void Create_And_Run_UI()
        {

        }
    // get.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.FileReadWrite Get_FileReadWrite()
        {
            return _FileReadWrite;
        }
    // set.

// private.
        private void Create_FileReadWrite(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.FileReadWrite fileReadWrite)
        {
            _FileReadWrite = fileReadWrite;
        }
    // get.
    // set.
    }
}
