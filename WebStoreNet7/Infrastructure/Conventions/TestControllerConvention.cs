using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace WebStoreNet7.Infrastructure.Convenctions
{
	public class TestControllerConvention : IControllerModelConvention
	{
		public void Apply(ControllerModel controller)
		{
			//controller.Actions.Add(new ActionModel());
		}
	}
}
