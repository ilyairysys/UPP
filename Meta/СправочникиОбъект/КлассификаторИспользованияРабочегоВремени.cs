
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	///<summary>
	///(����)
	///</summary>
	public partial class �����������������������������������������:����������������
	{
		public bool _��������;
		public bool ��������()
		{
			return _��������;
		}
		public Guid ������;
		public long ������;
		/*static ��� ����� ������� � ������� ����������*/
		/*������ ������ ���������������� �� ������*/
		public bool ���������������;
		public bool ����������������;
		public Guid ��������;
		public bool ���������;
		public Guid ��������;
		public string/*50*/ ������������;
		public string/*(2)*/ ������������;//��������� ���
		public string/*(2)*/ �����������;//�������� ���
		public string/*(0)*/ ������������������;//������ ������������
		public V82.������������/*������*/.����������� �����������������;//������� ��� �������
		public bool ������������;//������� �����
		public void ��������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					if(_��������)
					{
						�������.CommandText = @"
						Insert Into _Reference115(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Description
						,_Fld2400
						,_Fld2401
						,_Fld2402
						,_Fld2403RRef
						,_Fld2404)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@������������
						,@������������
						,@�����������
						,@������������������
						,@�����������������
						,@������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference115
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Description	= @������������
						,_Fld2400	= @������������
						,_Fld2401	= @�����������
						,_Fld2402	= @������������������
						,_Fld2403RRef	= @�����������������
						,_Fld2404	= @������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("������������������", ������������������);
					�������.Parameters.AddWithValue("�����������������", �����������������.����());
					�������.Parameters.AddWithValue("������������", ������������);
					�������.ExecuteNonQuery();
				}
			}
		}
		public void �������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Delete _Reference115
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
