
namespace OpenAvrilNNI
{
    public class Execute
    {
// classes.
        private OpenAvrilNNI.FileReadWrite _FileReadWrite;
        
// registers.

// constructor.
        public Execute()
        {
            //System.Console.WriteLine("entered Execute.");
            Create_FileReadWrite();
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
        public OpenAvrilNNI.FileReadWrite Get_FileReadWrite()
        {
            return _FileReadWrite;
        }
    // set.

// private.
        private void Create_FileReadWrite()
        {
            Set_FileReadWrite(new FileReadWrite());
            while (Get_FileReadWrite() == null) { }
        }
    // get.
    // set.
        private void Set_FileReadWrite(OpenAvrilNNI.FileReadWrite newFileReadWrite)
        {
            _FileReadWrite = newFileReadWrite;
        }
    }
}
