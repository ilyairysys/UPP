
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ReglamentirovannyeOtchety")]
	[Route("/Catalogs/ReglamentirovannyeOtchety/{Code}")]
	public class ReglamentirovannyeOtchetyRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<ReglamentirovannyeOtchetyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ReglamentirovannyeOtchetyResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ReglamentirovannyeOtchetys")]
	[Route("/Catalogs/ReglamentirovannyeOtchetys/{Codes}")]
	public class ReglamentirovannyeOtchetysRequest/*������������������������������*/: IReturn<List<ReglamentirovannyeOtchetyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ReglamentirovannyeOtchetysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ReglamentirovannyeOtchetysResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class ReglamentirovannyeOtchetyService /*������������������������������*/ : Service
	{
		public object Any(ReglamentirovannyeOtchetyRequest request)
		{
			return new ReglamentirovannyeOtchetyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ReglamentirovannyeOtchetyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new ReglamentirovannyeOtchetyResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(ReglamentirovannyeOtchetysRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
