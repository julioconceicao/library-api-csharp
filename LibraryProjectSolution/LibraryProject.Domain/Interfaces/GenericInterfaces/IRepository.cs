namespace LibraryProject.Domain.Interfaces.GenericInterfaces
{
    public interface IRepository <T>
    {
        Task Add(T entity);
        Task Delete(Guid id);
        Task Update(T entity);

        Task <T> FindById (Guid id);
        Task <T> FindByTitle (string title);
        Task <IEnumerable<T>> FindByLanguage (string bookLanguage);    
    }
}