
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum ���������������������������
	{
		������������ = - 1,
	///<summary>
	///������������ �� ����� ���� �/�, �� 31.12.2006 �.
	///</summary>
		���������3���� = 0,//�� 3-� ��� �����������, �� 15-�� ��� � ����������
	///<summary>
	///������������ ���� �/�, �� ����� ������ - 50%
	///</summary>
		���������7����������������������� = 1,//�� 3-� �� 7-�� ��� ����������� (��� ���������� � ����� ��������)
	///<summary>
	///������������ ���� �/�, �� ����� 10 ���� - 50%
	///</summary>
		���������7������������������������� = 2,//�� 3-� �� 7-�� ��� ����������� (��� �� ���������� � ����� ��������)
	///<summary>
	///������������ ��� ������, ������ - 50%
	///</summary>
		���������15����������������������� = 3,//�� 7 �� 15-�� ��� ����������� (��� ���������� � ����� ��������)
	///<summary>
	///������������ ��� ������, � 11-�� ��� - 50%
	///</summary>
		���������15������������������������� = 4,//�� 7 �� 15-�� ��� ����������� (��� �� ���������� � ����� ��������)
	///<summary>
	///� 1.1.2007
	///</summary>
		���������7���������������� = 5,//(09) �� 7-�� ���, �����������
	///<summary>
	///� 1.1.2007
	///</summary>
		���������7���������������� = 6,//(09) �� 7-�� ���, � ����������
		���������7������������������������������������ = 7,//(12) �� 7-�� ���, �����������, ����������� �������� � ��������
		���������7������������������������������������ = 8,//(12) �� 7-�� ���, � ����������, ��� �����������, ���������� � ��������
		���������15���������������� = 9,//(09) �� 7 �� 15-�� ���, �����������
		���������15���������������� = 10,//(09) �� 7 �� 15-�� ���, � ����������
		������������������������������������� = 11,//(13) ��������� �� 15-�� ���, �����������
		������������������������������������� = 12,//(13) ��������� �� 15-�� ���, � ����������
		���������15��������������������������������������������� = 13,//(14) �� 15-�� ��� ��� ���������������� ����������, �����������
		���������15��������������������������������������������� = 14,//(14) �� 15-�� ��� ��� ���������������� ����������, � ����������
		���������15����������� = 15,//(15) �� 15-�� ���, ���-��������������, � ����������
	}
	public static partial class ���������������������������_��������//:������������������
	{
		///<summary>
		///������������ �� ����� ���� �/�, �� 31.12.2006 �.
		///</summary>
		public static readonly Guid ���������3���� = new Guid("7b5e3a97-4c18-5040-434b-c82556aa3ea4");//�� 3-� ��� �����������, �� 15-�� ��� � ����������
		///<summary>
		///������������ ���� �/�, �� ����� ������ - 50%
		///</summary>
		public static readonly Guid ���������7����������������������� = new Guid("a6e10c9a-5bf1-26d7-45c5-a6b7d7e9bb8e");//�� 3-� �� 7-�� ��� ����������� (��� ���������� � ����� ��������)
		///<summary>
		///������������ ���� �/�, �� ����� 10 ���� - 50%
		///</summary>
		public static readonly Guid ���������7������������������������� = new Guid("87c80993-4c9e-d112-4b1f-1b30b1b2cacb");//�� 3-� �� 7-�� ��� ����������� (��� �� ���������� � ����� ��������)
		///<summary>
		///������������ ��� ������, ������ - 50%
		///</summary>
		public static readonly Guid ���������15����������������������� = new Guid("f514ec97-aad9-53d1-4ec5-557ea2304756");//�� 7 �� 15-�� ��� ����������� (��� ���������� � ����� ��������)
		///<summary>
		///������������ ��� ������, � 11-�� ��� - 50%
		///</summary>
		public static readonly Guid ���������15������������������������� = new Guid("4be76080-d508-0573-4493-021b1526a627");//�� 7 �� 15-�� ��� ����������� (��� �� ���������� � ����� ��������)
		///<summary>
		///� 1.1.2007
		///</summary>
		public static readonly Guid ���������7���������������� = new Guid("1ac061be-4c31-e304-46ac-2816cbf6cd8a");//(09) �� 7-�� ���, �����������
		///<summary>
		///� 1.1.2007
		///</summary>
		public static readonly Guid ���������7���������������� = new Guid("ff56198d-d2f8-13b9-48ae-80d85c5639d2");//(09) �� 7-�� ���, � ����������
		public static readonly Guid ���������7������������������������������������ = new Guid("11cb4489-3b3b-4430-4d82-3692cc3ef87b");//(12) �� 7-�� ���, �����������, ����������� �������� � ��������
		public static readonly Guid ���������7������������������������������������ = new Guid("dd674b9f-9a77-eef1-4081-32bfc1666607");//(12) �� 7-�� ���, � ����������, ��� �����������, ���������� � ��������
		public static readonly Guid ���������15���������������� = new Guid("fc0b4288-2bcc-71e3-4a0f-ecfdc30bc644");//(09) �� 7 �� 15-�� ���, �����������
		public static readonly Guid ���������15���������������� = new Guid("eccbb892-e57e-cf00-4890-2b0c1b70b261");//(09) �� 7 �� 15-�� ���, � ����������
		public static readonly Guid ������������������������������������� = new Guid("b80253b2-8c52-0108-4683-43afb3ceff46");//(13) ��������� �� 15-�� ���, �����������
		public static readonly Guid ������������������������������������� = new Guid("53dd1ba3-26f0-0e84-4822-5d64d655568c");//(13) ��������� �� 15-�� ���, � ����������
		public static readonly Guid ���������15��������������������������������������������� = new Guid("3e207faf-a63d-8146-4129-ec719947950d");//(14) �� 15-�� ��� ��� ���������������� ����������, �����������
		public static readonly Guid ���������15��������������������������������������������� = new Guid("40104c90-6e80-40b6-4d06-601c435c5ffd");//(14) �� 15-�� ��� ��� ���������������� ����������, � ����������
		public static readonly Guid ���������15����������� = new Guid("7549a195-4b18-bedf-412f-2aa5bfe772d0");//(15) �� 15-�� ���, ���-��������������, � ����������
		public static ��������������������������� ��������(this ��������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������������� ��������(this ��������������������������� ��������, Guid ������)
		{
			if(������ == ���������3����)
			{
				return ���������������������������.���������3����;
			}
			else if(������ == ���������7�����������������������)
			{
				return ���������������������������.���������7�����������������������;
			}
			else if(������ == ���������7�������������������������)
			{
				return ���������������������������.���������7�������������������������;
			}
			else if(������ == ���������15�����������������������)
			{
				return ���������������������������.���������15�����������������������;
			}
			else if(������ == ���������15�������������������������)
			{
				return ���������������������������.���������15�������������������������;
			}
			else if(������ == ���������7����������������)
			{
				return ���������������������������.���������7����������������;
			}
			else if(������ == ���������7����������������)
			{
				return ���������������������������.���������7����������������;
			}
			else if(������ == ���������7������������������������������������)
			{
				return ���������������������������.���������7������������������������������������;
			}
			else if(������ == ���������7������������������������������������)
			{
				return ���������������������������.���������7������������������������������������;
			}
			else if(������ == ���������15����������������)
			{
				return ���������������������������.���������15����������������;
			}
			else if(������ == ���������15����������������)
			{
				return ���������������������������.���������15����������������;
			}
			else if(������ == �������������������������������������)
			{
				return ���������������������������.�������������������������������������;
			}
			else if(������ == �������������������������������������)
			{
				return ���������������������������.�������������������������������������;
			}
			else if(������ == ���������15���������������������������������������������)
			{
				return ���������������������������.���������15���������������������������������������������;
			}
			else if(������ == ���������15���������������������������������������������)
			{
				return ���������������������������.���������15���������������������������������������������;
			}
			else if(������ == ���������15�����������)
			{
				return ���������������������������.���������15�����������;
			}
			return ���������������������������.������������;
		}
		public static byte[] ����(this ��������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������������������� ��������)
		{
			switch (��������)
			{
				case ���������������������������.���������3����: return ���������3����;
				case ���������������������������.���������7�����������������������: return ���������7�����������������������;
				case ���������������������������.���������7�������������������������: return ���������7�������������������������;
				case ���������������������������.���������15�����������������������: return ���������15�����������������������;
				case ���������������������������.���������15�������������������������: return ���������15�������������������������;
				case ���������������������������.���������7����������������: return ���������7����������������;
				case ���������������������������.���������7����������������: return ���������7����������������;
				case ���������������������������.���������7������������������������������������: return ���������7������������������������������������;
				case ���������������������������.���������7������������������������������������: return ���������7������������������������������������;
				case ���������������������������.���������15����������������: return ���������15����������������;
				case ���������������������������.���������15����������������: return ���������15����������������;
				case ���������������������������.�������������������������������������: return �������������������������������������;
				case ���������������������������.�������������������������������������: return �������������������������������������;
				case ���������������������������.���������15���������������������������������������������: return ���������15���������������������������������������������;
				case ���������������������������.���������15���������������������������������������������: return ���������15���������������������������������������������;
				case ���������������������������.���������15�����������: return ���������15�����������;
			}
			return Guid.Empty;
		}
	}
}
