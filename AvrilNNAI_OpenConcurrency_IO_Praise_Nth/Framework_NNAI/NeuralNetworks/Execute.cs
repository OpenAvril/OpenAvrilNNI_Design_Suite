
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Execute
    {
// classes.

// registers.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.FileRead _FileReadWrite;

// constructor.
        public Execute()
        {
            //System.Console.WriteLine("entered Execute.");
            Create_FileRead(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.FileRead());
            while (Get_FileRead() == null) { }
        }

// destructor.
        ~Execute()
        {

        }

// public.

    // get.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.FileRead Get_FileRead()
        {
            return _FileReadWrite;
        }
    // set.

// private.
        private void Create_FileRead(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.FileRead fileReadWrite)
        {
            _FileReadWrite = fileReadWrite;
        }
    // get.
    // set.
    }
}
