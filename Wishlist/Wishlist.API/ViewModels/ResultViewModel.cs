namespace Wishlist.API.ViewModels
{
    public class ResultViewModel<T>
    {
        public T? Data { get; private set; }
        public string? Error { get; private set; }

        public ResultViewModel(T data)
        {
            Data = data;
        }

        public ResultViewModel(string error)
        {
            Error = error;
        }
    }
}
