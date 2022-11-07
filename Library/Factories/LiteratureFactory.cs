using Library.Collection;

namespace Library
{
    abstract class LiteratureFactory
    {
        public abstract LinkList<Literature> CreateLiterature();
        public abstract Author CreateAuthor();
        public abstract Genre CreateGenre();
    }
}
