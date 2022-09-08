namespace LibraryProject.Domain.Interfaces.GenericInterfaces
{
    public interface IRepository <T>
    {
        Task Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);

        Task <T> FindById (Guid id);
        Task <T> FindByTitle (string title);
        Task <T> FindByLanguage (string bookLanguage);    
    }
}