
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum ��������������
	{
		������������ = - 1,
		����������� = 0,//������ �����
		����������� = 1,
		������������������������������������������ = 2,//������ ������������ � �������������� ���������
		����������������������������� = 3,//������������ ������ �����������, ����������������� ������ ������������� ����������� ��������
		��������������������������������������������������������������������� = 4,//�������� ������������� ������� �����������, ����������� ������������� �� ������ ����������� ������ ��� ������ ����������������
		������������������������������������������������������������������������� = 5,//������������ ����������� �� ��������� ������������� ����������� ����� ����������, ����������� ����������� � (���) ������������������ ����������� ����������� ����������
	///<summary>
	///��������������� ������ (�. 1.1 ��. 259 �� ��)
	///</summary>
		��������������������� = 6,//��������������� ������
		���������������������� = 7,//��������������� �������
		������������������� = 8,//������������ �������
		���������������������� = 9,//������� ��������� ������
		��������������� = 10,//��������� ������
		������������ = 11,//������ � �����
		����� = 12,
		����������������������������� = 13,//����� �� ������� ������������� ��
		��������������������������������������������� = 14,//������������ � ������������ ����������� ���������
		������������� = 15,//������ �������
		������������������������ = 16,//����������������� �������
		��������������������������� = 17,//������� �� ������� (�����������)
		��������������������� = 18,//������ �������� �������
		���������������������������������������������������� = 19,//������� �� ���������� ������ ���������� �� ������ ���������
		������������������������� = 20,//�������� ��������� ��������
		���������������������������������� = 21,//�� ����������� � ����� ���������������
		��� = 22,
		������������������� = 23,//������������ �������
	}
	public static partial class ��������������_��������//:������������������
	{
		public static readonly Guid ����������� = new Guid("20c8da84-a4bf-64cd-45fa-f819220010a4");//������ �����
		public static readonly Guid ����������� = new Guid("64d7adb2-f1ae-7543-4bae-575baff37a1f");
		public static readonly Guid ������������������������������������������ = new Guid("7baaad86-7716-46a3-4f30-94b254e3a73e");//������ ������������ � �������������� ���������
		public static readonly Guid ����������������������������� = new Guid("a6dcec8c-d358-5e9e-4fcf-6d84ce34658a");//������������ ������ �����������, ����������������� ������ ������������� ����������� ��������
		public static readonly Guid ��������������������������������������������������������������������� = new Guid("2390b485-44cd-5ac6-453b-c69894b7517b");//�������� ������������� ������� �����������, ����������� ������������� �� ������ ����������� ������ ��� ������ ����������������
		public static readonly Guid ������������������������������������������������������������������������� = new Guid("318416b2-6193-9363-426a-2363d6fc52cd");//������������ ����������� �� ��������� ������������� ����������� ����� ����������, ����������� ����������� � (���) ������������������ ����������� ����������� ����������
		///<summary>
		///��������������� ������ (�. 1.1 ��. 259 �� ��)
		///</summary>
		public static readonly Guid ��������������������� = new Guid("95e9d7a7-db1f-9aad-438e-53dd712a26a2");//��������������� ������
		public static readonly Guid ���������������������� = new Guid("303199b8-3151-b07b-45e6-140edb761c8f");//��������������� �������
		public static readonly Guid ������������������� = new Guid("d0019dbb-81a8-580b-4304-610cf518a03a");//������������ �������
		public static readonly Guid ���������������������� = new Guid("030b849a-9225-c251-4a91-d948a1a6b242");//������� ��������� ������
		public static readonly Guid ��������������� = new Guid("fe139a9d-8a02-845f-4c7e-6cff0ad2c61c");//��������� ������
		public static readonly Guid ������������ = new Guid("a5e20089-53ff-7c2c-443e-57bf4639d355");//������ � �����
		public static readonly Guid ����� = new Guid("53bb3e95-8e88-bc5a-49c0-5038113f705a");
		public static readonly Guid ����������������������������� = new Guid("ce769fba-73df-ac70-443c-86175afc2e52");//����� �� ������� ������������� ��
		public static readonly Guid ��������������������������������������������� = new Guid("a394f6a0-2768-ba92-4e16-eae4c074d7c1");//������������ � ������������ ����������� ���������
		public static readonly Guid ������������� = new Guid("93b05087-ff2b-a8ce-4392-4d40f79afd23");//������ �������
		public static readonly Guid ������������������������ = new Guid("70d5f991-d8de-6f0d-4e3a-7175adcdc111");//����������������� �������
		public static readonly Guid ��������������������������� = new Guid("5b8ce78b-05e4-a668-4f81-e21a02fa23ad");//������� �� ������� (�����������)
		public static readonly Guid ��������������������� = new Guid("cbd8579c-9d8f-db2c-466a-84f7af8ab34b");//������ �������� �������
		public static readonly Guid ���������������������������������������������������� = new Guid("2f8a74ae-cdc0-6295-45bc-17b370dd5007");//������� �� ���������� ������ ���������� �� ������ ���������
		public static readonly Guid ������������������������� = new Guid("314d0280-bee4-e6d7-4656-41e5d14d1d70");//�������� ��������� ��������
		public static readonly Guid ���������������������������������� = new Guid("6c61dc82-d993-83d4-4a8c-971227be64a0");//�� ����������� � ����� ���������������
		public static readonly Guid ��� = new Guid("3120a8b8-d4d2-ad62-48f2-785217bc7a24");
		public static readonly Guid ������������������� = new Guid("1bd03b87-9621-6a7d-4475-b47df123dae2");//������������ �������
		public static �������������� ��������(this �������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �������������� ��������(this �������������� ��������, Guid ������)
		{
			if(������ == �����������)
			{
				return ��������������.�����������;
			}
			else if(������ == �����������)
			{
				return ��������������.�����������;
			}
			else if(������ == ������������������������������������������)
			{
				return ��������������.������������������������������������������;
			}
			else if(������ == �����������������������������)
			{
				return ��������������.�����������������������������;
			}
			else if(������ == ���������������������������������������������������������������������)
			{
				return ��������������.���������������������������������������������������������������������;
			}
			else if(������ == �������������������������������������������������������������������������)
			{
				return ��������������.�������������������������������������������������������������������������;
			}
			else if(������ == ���������������������)
			{
				return ��������������.���������������������;
			}
			else if(������ == ����������������������)
			{
				return ��������������.����������������������;
			}
			else if(������ == �������������������)
			{
				return ��������������.�������������������;
			}
			else if(������ == ����������������������)
			{
				return ��������������.����������������������;
			}
			else if(������ == ���������������)
			{
				return ��������������.���������������;
			}
			else if(������ == ������������)
			{
				return ��������������.������������;
			}
			else if(������ == �����)
			{
				return ��������������.�����;
			}
			else if(������ == �����������������������������)
			{
				return ��������������.�����������������������������;
			}
			else if(������ == ���������������������������������������������)
			{
				return ��������������.���������������������������������������������;
			}
			else if(������ == �������������)
			{
				return ��������������.�������������;
			}
			else if(������ == ������������������������)
			{
				return ��������������.������������������������;
			}
			else if(������ == ���������������������������)
			{
				return ��������������.���������������������������;
			}
			else if(������ == ���������������������)
			{
				return ��������������.���������������������;
			}
			else if(������ == ����������������������������������������������������)
			{
				return ��������������.����������������������������������������������������;
			}
			else if(������ == �������������������������)
			{
				return ��������������.�������������������������;
			}
			else if(������ == ����������������������������������)
			{
				return ��������������.����������������������������������;
			}
			else if(������ == ���)
			{
				return ��������������.���;
			}
			else if(������ == �������������������)
			{
				return ��������������.�������������������;
			}
			return ��������������.������������;
		}
		public static byte[] ����(this �������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this �������������� ��������)
		{
			switch (��������)
			{
				case ��������������.�����������: return �����������;
				case ��������������.�����������: return �����������;
				case ��������������.������������������������������������������: return ������������������������������������������;
				case ��������������.�����������������������������: return �����������������������������;
				case ��������������.���������������������������������������������������������������������: return ���������������������������������������������������������������������;
				case ��������������.�������������������������������������������������������������������������: return �������������������������������������������������������������������������;
				case ��������������.���������������������: return ���������������������;
				case ��������������.����������������������: return ����������������������;
				case ��������������.�������������������: return �������������������;
				case ��������������.����������������������: return ����������������������;
				case ��������������.���������������: return ���������������;
				case ��������������.������������: return ������������;
				case ��������������.�����: return �����;
				case ��������������.�����������������������������: return �����������������������������;
				case ��������������.���������������������������������������������: return ���������������������������������������������;
				case ��������������.�������������: return �������������;
				case ��������������.������������������������: return ������������������������;
				case ��������������.���������������������������: return ���������������������������;
				case ��������������.���������������������: return ���������������������;
				case ��������������.����������������������������������������������������: return ����������������������������������������������������;
				case ��������������.�������������������������: return �������������������������;
				case ��������������.����������������������������������: return ����������������������������������;
				case ��������������.���: return ���;
				case ��������������.�������������������: return �������������������;
			}
			return Guid.Empty;
		}
	}
}
