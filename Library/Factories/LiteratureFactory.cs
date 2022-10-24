using Library.Collection;

namespace Library
{
    abstract class LiteratureFactory
    {
        public abstract LinkList<Literature> CreateLiterature();
        public abstract LinkList<Author> CreateAuthor();
        public abstract LinkList<Genre> CreateGenre();
    }
}
