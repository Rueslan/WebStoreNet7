namespace WebStoreNet7.Infrastructure.Middleware
{
	public class TestMiddleware
	{
        private readonly RequestDelegate _Next;
		private readonly ILogger<TestMiddleware> _Logger;
		public TestMiddleware(RequestDelegate next, ILogger<TestMiddleware> Logger)
        {
            _Next = next;
            _Logger = Logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //Предобработка

            var processing = _Next(context);

			//обработка параллельно

			await processing;

            //Постобработка
        }
    }
}
