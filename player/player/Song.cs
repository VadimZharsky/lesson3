namespace player
{
    public class Song
    {
        public bool locked, isPlaying = false;
        public string lyrics
        {
            get => "some lyrics";
        }
        public bool Lock()
        {
            return locked = true;
        }
        public bool Unlockock()
        {
            return locked = false;
        }
    }
}