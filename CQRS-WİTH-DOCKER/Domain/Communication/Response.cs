namespace CQRS_WİTH_DOCKER.Domain.Communication
{
    public class Response<T>
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }
        public T Data { get; protected set; }

        public Response(bool success, string message, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        /// <summary>
        /// Failure response
        /// </summary>
        /// <param name="message"></param>
        public Response(string message) : this(false, message, default(T))
        {

        }

        /// <summary>
        /// Successfull data
        /// </summary>
        /// <param name="data"></param>
        public Response(T data) : this(true, string.Empty, data)
        {

        }
    }
}
