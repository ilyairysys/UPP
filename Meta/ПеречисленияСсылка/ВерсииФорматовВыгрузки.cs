
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ����������������������
	{
		������������ = - 1,
		������200 = 0,//������ 2.00
		������201 = 1,//������ 2.01
		������300 = 2,//������ 3.00
		������201���� = 3,//������ 2.01 ��� ���������� �� ��������
		������300���� = 4,//������ 3.00 ��� ���������� �� ��������
		������301���� = 5,//������ 3.01 ��� ���������� �� ��������
		������400 = 6,//������ 4.00
		������500 = 7,//������ 5.00
		������302���� = 8,//������ 3.02 ��� ���������� �� ��������
		������700��� = 9,//������ 7.00 ���
		��������� = 10,//������ ���
		������401���� = 11,//������ 4.01 ��� ���������� �� ��������
	///<summary>
	///��� ��������������
	///</summary>
		���������� = 12,//������ ����
	}
	public static partial class ����������������������_��������//:������������������
	{
		public static readonly Guid ������200 = new Guid("0623d8bf-b538-dbdf-4609-b3cdb7f3eb9c");//������ 2.00
		public static readonly Guid ������201 = new Guid("1dfadba0-a11d-f978-495d-140232e7c757");//������ 2.01
		public static readonly Guid ������300 = new Guid("8c7c99ae-ba75-0672-4395-ab8ae2ab021a");//������ 3.00
		public static readonly Guid ������201���� = new Guid("8ee498b6-62c8-1900-4852-f03a63a61c39");//������ 2.01 ��� ���������� �� ��������
		public static readonly Guid ������300���� = new Guid("4f98a487-51d1-de9f-4427-a9b66e110bdf");//������ 3.00 ��� ���������� �� ��������
		public static readonly Guid ������301���� = new Guid("401d48aa-94b0-1a28-40a9-c8f58a017bac");//������ 3.01 ��� ���������� �� ��������
		public static readonly Guid ������400 = new Guid("0f995c8a-332c-a742-4614-9d7885c99c2e");//������ 4.00
		public static readonly Guid ������500 = new Guid("0a6f00b7-99c9-d639-4495-ab0c85f2911e");//������ 5.00
		public static readonly Guid ������302���� = new Guid("ba4814b4-6a7b-589c-4d46-6717b8fee401");//������ 3.02 ��� ���������� �� ��������
		public static readonly Guid ������700��� = new Guid("39f85bbd-f5f6-cfc1-4dcb-d13e05e1abb5");//������ 7.00 ���
		public static readonly Guid ��������� = new Guid("e5027c88-13e8-fcfa-45c9-6559eceafe2e");//������ ���
		public static readonly Guid ������401���� = new Guid("a37d688a-aa84-b23e-4d96-e8bf7be724b0");//������ 4.01 ��� ���������� �� ��������
		///<summary>
		///��� ��������������
		///</summary>
		public static readonly Guid ���������� = new Guid("17c6ac87-0fef-9204-42b8-967fc6fa63e9");//������ ����
		public static ���������������������� ��������(this ���������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������������� ��������(this ���������������������� ��������, Guid ������)
		{
			if(������ == ������200)
			{
				return ����������������������.������200;
			}
			else if(������ == ������201)
			{
				return ����������������������.������201;
			}
			else if(������ == ������300)
			{
				return ����������������������.������300;
			}
			else if(������ == ������201����)
			{
				return ����������������������.������201����;
			}
			else if(������ == ������300����)
			{
				return ����������������������.������300����;
			}
			else if(������ == ������301����)
			{
				return ����������������������.������301����;
			}
			else if(������ == ������400)
			{
				return ����������������������.������400;
			}
			else if(������ == ������500)
			{
				return ����������������������.������500;
			}
			else if(������ == ������302����)
			{
				return ����������������������.������302����;
			}
			else if(������ == ������700���)
			{
				return ����������������������.������700���;
			}
			else if(������ == ���������)
			{
				return ����������������������.���������;
			}
			else if(������ == ������401����)
			{
				return ����������������������.������401����;
			}
			else if(������ == ����������)
			{
				return ����������������������.����������;
			}
			return ����������������������.������������;
		}
		public static byte[] ����(this ���������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������������������� ��������)
		{
			switch (��������)
			{
				case ����������������������.������200: return ������200;
				case ����������������������.������201: return ������201;
				case ����������������������.������300: return ������300;
				case ����������������������.������201����: return ������201����;
				case ����������������������.������300����: return ������300����;
				case ����������������������.������301����: return ������301����;
				case ����������������������.������400: return ������400;
				case ����������������������.������500: return ������500;
				case ����������������������.������302����: return ������302����;
				case ����������������������.������700���: return ������700���;
				case ����������������������.���������: return ���������;
				case ����������������������.������401����: return ������401����;
				case ����������������������.����������: return ����������;
			}
			return Guid.Empty;
		}
	}
}
