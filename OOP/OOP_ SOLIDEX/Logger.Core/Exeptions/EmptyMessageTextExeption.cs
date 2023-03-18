
namespace Logger.Core.Exeptions
{
    public class EmptyCreatedTimeExeption : Exception
    {
        private const string DefaultMessage = "Created time of massage cannot be null or withespace";
        public EmptyCreatedTimeExeption() : base(DefaultMessage) 
        {
        }

        public EmptyCreatedTimeExeption(string message)
            :base(message)
        {   
        }
    }
}
