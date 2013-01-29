
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Voenkomaty")]
	[Route("/Catalogs/Voenkomaty/{Code}")]
	public class VoenkomatyRequest/*����������������*/: V82.�����������������.����������,IReturn<VoenkomatyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VoenkomatyResponse//���������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Voenkomatys")]
	[Route("/Catalogs/Voenkomatys/{Codes}")]
	public class VoenkomatysRequest/*����������������*/: IReturn<List<VoenkomatyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VoenkomatysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VoenkomatysResponse//���������������
	{
		public string Result {get;set;}
	}


	public class VoenkomatyService /*����������������*/ : Service
	{
		public object Any(VoenkomatyRequest request)
		{
			return new VoenkomatyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VoenkomatyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������.�����������(���������);
				if (������ == null)
				{
					return new VoenkomatyResponse() {Result = "���������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������.�����������(1);
			}
		}

		public object Get(VoenkomatysRequest request)
		{
			var ��������� = new List<V82.�����������������.����������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������.�����������(���������);
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
