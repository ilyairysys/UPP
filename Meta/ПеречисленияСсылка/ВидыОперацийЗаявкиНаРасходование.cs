
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ��������������������������������
	{
		������������ = - 1,
		���������������� = 0,//������ ����������
		�������������������������������� = 1,//������� ����������
		��������������������������������� = 2,//������ ������������ ����
		����������������������������� = 3,//������ � ����� ���
		�������������������������������������� = 4,//������� �� �������� � ������ � �������������
		������������������������������������ = 5,//������� �� �������� � ������ � �����������
	///<summary>
	///(���)
	///</summary>
		������������������ = 6,//������������ ������
	///<summary>
	///(���)
	///</summary>
		�������������� = 7,//������� ���������� �����
		��������������������������� = 8,//������ ������
		��������������������������� = 9,//������ ������� � �������������
	}
	public static partial class ��������������������������������_��������//:������������������
	{
		public static readonly Guid ���������������� = new Guid("db125094-3652-79a6-4d64-b72cea38777a");//������ ����������
		public static readonly Guid �������������������������������� = new Guid("07881cbe-a74c-ad24-4978-2e15f3906bdf");//������� ����������
		public static readonly Guid ��������������������������������� = new Guid("f3138084-c967-9bb1-40be-684494b3b20c");//������ ������������ ����
		public static readonly Guid ����������������������������� = new Guid("425f2197-ac7c-bc63-4751-7d4ebcff634a");//������ � ����� ���
		public static readonly Guid �������������������������������������� = new Guid("83011ea7-90be-2abc-48d2-59193465f2bc");//������� �� �������� � ������ � �������������
		public static readonly Guid ������������������������������������ = new Guid("e5538786-3593-44ca-41ae-6b3153443006");//������� �� �������� � ������ � �����������
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������������������ = new Guid("59d04d88-8ca0-ac69-408f-84eec834073a");//������������ ������
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid �������������� = new Guid("ea6f0d9a-3da4-a2e5-4b9a-9c5b201eb1e7");//������� ���������� �����
		public static readonly Guid ��������������������������� = new Guid("80128b9b-b064-14cf-4838-d93b79dae7ba");//������ ������
		public static readonly Guid ��������������������������� = new Guid("d398b78e-e2d1-1d00-48b6-dded8786a296");//������ ������� � �������������
		public static �������������������������������� ��������(this �������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �������������������������������� ��������(this �������������������������������� ��������, Guid ������)
		{
			if(������ == ����������������)
			{
				return ��������������������������������.����������������;
			}
			else if(������ == ��������������������������������)
			{
				return ��������������������������������.��������������������������������;
			}
			else if(������ == ���������������������������������)
			{
				return ��������������������������������.���������������������������������;
			}
			else if(������ == �����������������������������)
			{
				return ��������������������������������.�����������������������������;
			}
			else if(������ == ��������������������������������������)
			{
				return ��������������������������������.��������������������������������������;
			}
			else if(������ == ������������������������������������)
			{
				return ��������������������������������.������������������������������������;
			}
			else if(������ == ������������������)
			{
				return ��������������������������������.������������������;
			}
			else if(������ == ��������������)
			{
				return ��������������������������������.��������������;
			}
			else if(������ == ���������������������������)
			{
				return ��������������������������������.���������������������������;
			}
			else if(������ == ���������������������������)
			{
				return ��������������������������������.���������������������������;
			}
			return ��������������������������������.������������;
		}
		public static byte[] ����(this �������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this �������������������������������� ��������)
		{
			switch (��������)
			{
				case ��������������������������������.����������������: return ����������������;
				case ��������������������������������.��������������������������������: return ��������������������������������;
				case ��������������������������������.���������������������������������: return ���������������������������������;
				case ��������������������������������.�����������������������������: return �����������������������������;
				case ��������������������������������.��������������������������������������: return ��������������������������������������;
				case ��������������������������������.������������������������������������: return ������������������������������������;
				case ��������������������������������.������������������: return ������������������;
				case ��������������������������������.��������������: return ��������������;
				case ��������������������������������.���������������������������: return ���������������������������;
				case ��������������������������������.���������������������������: return ���������������������������;
			}
			return Guid.Empty;
		}
	}
}
