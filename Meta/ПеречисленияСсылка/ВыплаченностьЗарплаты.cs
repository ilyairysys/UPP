
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum ���������������������
	{
		������������ = - 1,
		����������� = 0,//�� ���������
		��������� = 1,
		�������������� = 2,
	}
	public static partial class ���������������������_��������//:������������������
	{
		public static readonly Guid ����������� = new Guid("c0db76b2-717a-0c60-4cb6-f5dec52fa698");//�� ���������
		public static readonly Guid ��������� = new Guid("75ae53ad-3073-182f-4b59-8b0d48498c7a");
		public static readonly Guid �������������� = new Guid("6e1326a1-ebde-463c-443f-655124b7750d");
		public static ��������������������� ��������(this ��������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������� ��������(this ��������������������� ��������, Guid ������)
		{
			if(������ == �����������)
			{
				return ���������������������.�����������;
			}
			else if(������ == ���������)
			{
				return ���������������������.���������;
			}
			else if(������ == ��������������)
			{
				return ���������������������.��������������;
			}
			return ���������������������.������������;
		}
		public static byte[] ����(this ��������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������������� ��������)
		{
			switch (��������)
			{
				case ���������������������.�����������: return �����������;
				case ���������������������.���������: return ���������;
				case ���������������������.��������������: return ��������������;
			}
			return Guid.Empty;
		}
	}
}
