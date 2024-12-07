namespace School.Application.Core
{
    public abstract class BaseService
    {
      
        protected bool ValidateInput(object input) => input != null;
    }
}
