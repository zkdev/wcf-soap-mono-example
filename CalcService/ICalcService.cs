using System.ServiceModel;

namespace Service
{
	[ServiceContract]
	public interface ICalcService
	{
		[OperationContract]
		Result Add(Arguments args);
	}
}
