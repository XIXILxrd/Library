namespace Library
{
    abstract class HallFactory
    {
        public abstract List<Literature> CreateLiterature(int amount);
        public abstract List<Author> CreateAuthor();
        public abstract List<Genre> CreateGenre();
    }
}
