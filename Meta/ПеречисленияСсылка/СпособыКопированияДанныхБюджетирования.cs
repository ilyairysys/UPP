
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ��������������������������������������
	{
		������������ = - 1,
		����������������� = 0,//�� ��������� � ��������
		���������������������������������� = 1,//������������� ������������� ��������
	}
	public static partial class ��������������������������������������_��������//:������������������
	{
		public static readonly Guid ����������������� = new Guid("bec52885-722f-7dd4-4480-b0c229386d7e");//�� ��������� � ��������
		public static readonly Guid ���������������������������������� = new Guid("811e4fb6-bc1a-5cb2-4b0c-45c296ab76b5");//������������� ������������� ��������
		public static �������������������������������������� ��������(this �������������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �������������������������������������� ��������(this �������������������������������������� ��������, Guid ������)
		{
			if(������ == �����������������)
			{
				return ��������������������������������������.�����������������;
			}
			else if(������ == ����������������������������������)
			{
				return ��������������������������������������.����������������������������������;
			}
			return ��������������������������������������.������������;
		}
		public static byte[] ����(this �������������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this �������������������������������������� ��������)
		{
			switch (��������)
			{
				case ��������������������������������������.�����������������: return �����������������;
				case ��������������������������������������.����������������������������������: return ����������������������������������;
			}
			return Guid.Empty;
		}
	}
}
