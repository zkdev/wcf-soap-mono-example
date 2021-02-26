namespace Service
{
	public class CalcService : ICalcService
	{
		public Result Add(Arguments args)
		{
			return new Result
			{
				Value = args.Arg1 + args.Arg2
			};
		}
	}
}
