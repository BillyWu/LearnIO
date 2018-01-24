namespace SocketAsyncServer
{
    internal class AcceptOpUserToken
    {
        //The only reason to use this UserToken in our app is to give it an identifier,
        //so that you can see it in the program flow. Otherwise, you would not need it.
        internal int socketHandleNumber; //for testing only

        public AcceptOpUserToken(int identifier)
        {
            TokenId = identifier;
            //if (Program.watchProgramFlow == true)   //for testing
            //{
            //    Program.testWriter.WriteLine("AcceptOpUserToken constructor, idOfThisObject " + id);
            //}
        }

        public int TokenId { get; set; }
    }
}