namespace FreelaWeb.Core.Entities
{
    //Essa classe esta sendo criada por um motivo, toda classe de entidade precisa ter um id
    //então pra nao ficar repetindo o id em todas as classes de entidade, criamos essa classe
    //e todas as classes de entidade herdam dela
    public abstract class BaseEntity
    {
        protected BaseEntity() { }
        public int Id { get; private set; }

        //private set -> Não queremos que essa informação seja alterada fora do escopo dessa classe !!
    }
}
