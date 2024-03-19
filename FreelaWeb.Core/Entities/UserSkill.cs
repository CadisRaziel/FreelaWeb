namespace FreelaWeb.Core.Entities
{
    public class UserSkill : BaseEntity
    {
        //Entidade para realizar o relacionamento muitos para muitos do 'userSkill' na entidade 'User'
        public UserSkill(int idUser, int idSkill)
        {
            IdUser = idUser;
            IdSkill = idSkill;
        }
        public int IdUser { get; private set; }
        public int IdSkill { get; private set; }
    }
}
