
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum �������������������
	{
		������������ = - 1,
		������������������������ = 0,//���������� ��������������
	///<summary>
	///���� ������ ����������� ��� ��� ������� ������� (�� ���)
	///</summary>
		������������������� = 1,//������� ��� �� �������
		������������������ = 2,//������� ����-������� �� ����������
		���������� = 3,//��� ������� ����������
	///<summary>
	///������� ������������ �������� ��� �� ������������� �������� �������
	///</summary>
		������������������������� = 4,//������� ��� �� �������������
	///<summary>
	///���� ����� ��, � �������� ��������� ���, � ������������
	///</summary>
		���������������������� = 5,//�� ������� � ������������
	///<summary>
	///�������������� ���� ��������� ��� � ��������� ������������� ��������
	///</summary>
		�������������������� = 6,//��� ������� � ���������
	///<summary>
	///��� ����������� �����, ��� ���� ��� ������ � �������������� ���������� ������ ��� 0% ��� ���������� � �� �������� ������
	///</summary>
		��������������������0 = 7,//�������������� ������ 0%
		������������������0 = 8,//������������ ������ 0%
		��������������������0 = 9,//�� ������������ ������ 0%
		��������������� = 10,//������������ ���
		�������������������� = 11,//���������� ��� � ������
		��������������������0 = 12,//���������� ��� � ������ 0%
		������� = 13,
		������������������ = 14,//��� ������ �� �������
	}
	public static partial class �������������������_��������//:������������������
	{
		public static readonly Guid ������������������������ = new Guid("2f356aaf-f7a8-e352-4577-830bf6e04882");//���������� ��������������
		///<summary>
		///���� ������ ����������� ��� ��� ������� ������� (�� ���)
		///</summary>
		public static readonly Guid ������������������� = new Guid("f14a6e82-19b5-eb46-4df8-066c695b9f6d");//������� ��� �� �������
		public static readonly Guid ������������������ = new Guid("3b484b98-0f42-7ffd-4c2f-61c7f9edb1d5");//������� ����-������� �� ����������
		public static readonly Guid ���������� = new Guid("0a5029b7-37d4-9103-4773-d8edd4de17e0");//��� ������� ����������
		///<summary>
		///������� ������������ �������� ��� �� ������������� �������� �������
		///</summary>
		public static readonly Guid ������������������������� = new Guid("1a37419d-63b8-95a9-4e3a-d828d1986075");//������� ��� �� �������������
		///<summary>
		///���� ����� ��, � �������� ��������� ���, � ������������
		///</summary>
		public static readonly Guid ���������������������� = new Guid("64567291-a2d0-341d-4445-6a8103562d13");//�� ������� � ������������
		///<summary>
		///�������������� ���� ��������� ��� � ��������� ������������� ��������
		///</summary>
		public static readonly Guid �������������������� = new Guid("3215139c-22ba-9b82-4fdf-869f240d4ff8");//��� ������� � ���������
		///<summary>
		///��� ����������� �����, ��� ���� ��� ������ � �������������� ���������� ������ ��� 0% ��� ���������� � �� �������� ������
		///</summary>
		public static readonly Guid ��������������������0 = new Guid("6f3ab1b1-c4e4-1ef1-4339-ca7605c75b1f");//�������������� ������ 0%
		public static readonly Guid ������������������0 = new Guid("249529b5-6853-fb8a-4222-405ee9d9f25b");//������������ ������ 0%
		public static readonly Guid ��������������������0 = new Guid("d8ccb9b7-573a-3b28-4af5-e4fb3b87cac6");//�� ������������ ������ 0%
		public static readonly Guid ��������������� = new Guid("844f55a3-bc9e-bc9e-4476-6962a1b9c92e");//������������ ���
		public static readonly Guid �������������������� = new Guid("30fca08a-e6bd-2384-41e2-8fc6ac895d1e");//���������� ��� � ������
		public static readonly Guid ��������������������0 = new Guid("510e94b4-fe82-bc3a-4ada-97eabe8b473b");//���������� ��� � ������ 0%
		public static readonly Guid ������� = new Guid("b08df7b9-5619-2d41-4011-7d0b87f9d4a1");
		public static readonly Guid ������������������ = new Guid("3b3a899b-b80a-6f21-4521-aa3157f5c585");//��� ������ �� �������
		public static ������������������� ��������(this ������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������� ��������(this ������������������� ��������, Guid ������)
		{
			if(������ == ������������������������)
			{
				return �������������������.������������������������;
			}
			else if(������ == �������������������)
			{
				return �������������������.�������������������;
			}
			else if(������ == ������������������)
			{
				return �������������������.������������������;
			}
			else if(������ == ����������)
			{
				return �������������������.����������;
			}
			else if(������ == �������������������������)
			{
				return �������������������.�������������������������;
			}
			else if(������ == ����������������������)
			{
				return �������������������.����������������������;
			}
			else if(������ == ��������������������)
			{
				return �������������������.��������������������;
			}
			else if(������ == ��������������������0)
			{
				return �������������������.��������������������0;
			}
			else if(������ == ������������������0)
			{
				return �������������������.������������������0;
			}
			else if(������ == ��������������������0)
			{
				return �������������������.��������������������0;
			}
			else if(������ == ���������������)
			{
				return �������������������.���������������;
			}
			else if(������ == ��������������������)
			{
				return �������������������.��������������������;
			}
			else if(������ == ��������������������0)
			{
				return �������������������.��������������������0;
			}
			else if(������ == �������)
			{
				return �������������������.�������;
			}
			else if(������ == ������������������)
			{
				return �������������������.������������������;
			}
			return �������������������.������������;
		}
		public static byte[] ����(this ������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������� ��������)
		{
			switch (��������)
			{
				case �������������������.������������������������: return ������������������������;
				case �������������������.�������������������: return �������������������;
				case �������������������.������������������: return ������������������;
				case �������������������.����������: return ����������;
				case �������������������.�������������������������: return �������������������������;
				case �������������������.����������������������: return ����������������������;
				case �������������������.��������������������: return ��������������������;
				case �������������������.��������������������0: return ��������������������0;
				case �������������������.������������������0: return ������������������0;
				case �������������������.��������������������0: return ��������������������0;
				case �������������������.���������������: return ���������������;
				case �������������������.��������������������: return ��������������������;
				case �������������������.��������������������0: return ��������������������0;
				case �������������������.�������: return �������;
				case �������������������.������������������: return ������������������;
			}
			return Guid.Empty;
		}
	}
}
