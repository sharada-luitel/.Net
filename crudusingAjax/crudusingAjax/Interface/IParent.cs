using crudusingAjax.Data;

namespace crudusingAjax.Interface
{
    public interface IParent
    {
        List<Parent> GetParentsByEmployeeId(int employeeId);
        Parent GetParentById(int parentId);
        void Add(Parent parent);
        void Update(Parent parent);
        void Delete(int parentId);
    }
}
