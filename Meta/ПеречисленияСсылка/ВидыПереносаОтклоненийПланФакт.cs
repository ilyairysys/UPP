
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ������������������������������
	{
		������������ = - 1,
		��������������������� = 0,//������ �������� �������
		��������� = 1,//�� �������
	}
	public static partial class ������������������������������_��������//:������������������
	{
		public static readonly Guid ��������������������� = new Guid("a1bcefac-4eaa-0dd7-4a4f-5309e4b98d94");//������ �������� �������
		public static readonly Guid ��������� = new Guid("92e4a88a-527d-4a12-4332-bed08946153a");//�� �������
		public static ������������������������������ ��������(this ������������������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������������ ��������(this ������������������������������ ��������, Guid ������)
		{
			if(������ == ���������������������)
			{
				return ������������������������������.���������������������;
			}
			else if(������ == ���������)
			{
				return ������������������������������.���������;
			}
			return ������������������������������.������������;
		}
		public static byte[] ����(this ������������������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������������ ��������)
		{
			switch (��������)
			{
				case ������������������������������.���������������������: return ���������������������;
				case ������������������������������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
