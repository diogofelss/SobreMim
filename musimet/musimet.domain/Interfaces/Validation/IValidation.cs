using musimet.domain.Validation;

namespace musimet.domain.Interfaces.Validation
{
    public interface IValidation<TEntity> where TEntity : class
    {
        ValidationResult Valido(TEntity _entity);
    }
}