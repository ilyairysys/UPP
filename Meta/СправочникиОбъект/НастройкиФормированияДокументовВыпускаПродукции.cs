
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
	///��������� ������������ ���������� ������� ��������� �� ������ ���������� "����������� ���� ������������"
	///</summary>
	public partial class �����������������������������������������������:����������������
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
		public string/*70*/ ������������;
		///<summary>
		///����, �� ������� ������ ������ � �������������� ����������
		///</summary>
		public DateTime ����������������;//������� ���������
		public V82.�����������������.������������� �������������;
		public V82.������������/*������*/.������������� �����������������;//������ �����������
		public string/*(50)*/ �����������������������;//��� ����������� ���������
		public V82.�����������������.����������� �����������;
		public V82.�����������������.������������������������ ������������������������;//������������� �����������
		public V82.�����������������.������ �����;
		public bool ����������������������������;//�������� � �������������� �����
		public bool ���������������������������;//�������� � ������������� �����
		public bool �����������������������;//�������� � ��������� �����
		public bool ��������������;//�������� ������
		public bool �����������������;//�������� ���������
		public bool ������������������������������������;//�� ����������� ��������� �� ������, � ������� ���� ������������� �����
		///<summary>
		///����������� ��������� ������������� (������������ ��������)
		///</summary>
		public bool ���������������������������������;//����������� ��������� �������������
		///<summary>
		///���������� ������������� ������������� �������
		///</summary>
		public string/*(36)*/ �������������������;//������������ �������
		///<summary>
		///���������� ���� ����� ��������� �������, �� ��������� ������� ����������� ���������
		///</summary>
		public decimal/*(2)*/ ��������;
		public string/*(0)*/ �����������;
		public bool ��������������������������;//�� ������������ ��� ���������
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
						Insert Into _Reference158(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Description
						,_Fld2850
						,_Fld2851RRef
						,_Fld2852RRef
						,_Fld2853
						,_Fld2854RRef
						,_Fld2855RRef
						,_Fld2856RRef
						,_Fld2857
						,_Fld2858
						,_Fld2859
						,_Fld2860
						,_Fld2861
						,_Fld2862
						,_Fld2863
						,_Fld2864
						,_Fld2865
						,_Fld2866
						,_Fld2867)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@��������
						,@���������
						,@������������
						,@����������������
						,@�������������
						,@�����������������
						,@�����������������������
						,@�����������
						,@������������������������
						,@�����
						,@����������������������������
						,@���������������������������
						,@�����������������������
						,@��������������
						,@�����������������
						,@������������������������������������
						,@���������������������������������
						,@�������������������
						,@��������
						,@�����������
						,@��������������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference158
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_ParentIDRRef	= @��������
						,_Folder	= @���������
						,_Description	= @������������
						,_Fld2850	= @����������������
						,_Fld2851RRef	= @�������������
						,_Fld2852RRef	= @�����������������
						,_Fld2853	= @�����������������������
						,_Fld2854RRef	= @�����������
						,_Fld2855RRef	= @������������������������
						,_Fld2856RRef	= @�����
						,_Fld2857	= @����������������������������
						,_Fld2858	= @���������������������������
						,_Fld2859	= @�����������������������
						,_Fld2860	= @��������������
						,_Fld2861	= @�����������������
						,_Fld2862	= @������������������������������������
						,_Fld2863	= @���������������������������������
						,_Fld2864	= @�������������������
						,_Fld2865	= @��������
						,_Fld2866	= @�����������
						,_Fld2867	= @��������������������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("���������", ���������?new byte[]{0}:new byte[]{1});
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("�������������", �������������.������);
					�������.Parameters.AddWithValue("�����������������", �����������������.����());
					�������.Parameters.AddWithValue("�����������������������", �����������������������);
					�������.Parameters.AddWithValue("�����������", �����������.������);
					�������.Parameters.AddWithValue("������������������������", ������������������������.������);
					�������.Parameters.AddWithValue("�����", �����.������);
					�������.Parameters.AddWithValue("����������������������������", ����������������������������);
					�������.Parameters.AddWithValue("���������������������������", ���������������������������);
					�������.Parameters.AddWithValue("�����������������������", �����������������������);
					�������.Parameters.AddWithValue("��������������", ��������������);
					�������.Parameters.AddWithValue("�����������������", �����������������);
					�������.Parameters.AddWithValue("������������������������������������", ������������������������������������);
					�������.Parameters.AddWithValue("���������������������������������", ���������������������������������);
					�������.Parameters.AddWithValue("�������������������", �������������������);
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("��������������������������", ��������������������������);
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
					�������.CommandText = @"Delete _Reference158
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/
		////////////////////////////////////////////////////////////////////////////////
		// ����� ��������� � �������
		// ��������� �������� ������������� ����������.
		//
		// ���������
		//	��������� - ��������� ��������� �� ������
		//
		// ������������ ��������
		//	������  - ��� ����������� ��������� ���������
		//	����	- �� ��� ����������� ��������� ���������

		public object ������������������(/*���� ���������*/)
		{
			if(true/*���������*/)
			{
			}
			/*����� = ����;*/
			/*// ������ ���� ��������� ������������ ���������
*/
			/*�������������������������� = ����� ���������();*/
			/*��������������������������.��������("�����������������������", "�� ������ ��� ����������� ����������");*/
			/*��������������������������.��������("�����������������",	   "�� ������ ������ ����������� ����������� ����������");*/
			/*��������������������������.��������("�����������",			   "�� ������� �����������, �� ������� ����������� ���������");*/
			/*��������������������������.��������("�����",				   "�� ������ �����, �� �������� ����������� ���������");*/
			/*��������������������.���������������������������������(����������, ��������������������������, �����, ���������);*/
			/*// �������� ������ ������������ ���� �� � ������ ���� ����� (��������������, �������������, ���������)
*/
			/*����������������������� = ����� ���������("����������������������������,���������������������������,�����������������������");*/
			/*������������������������(�����������������������, ����������);*/
			/*����������������.����������������������������������(�����������������������, �����, ���������);*/
		}
		// �������������� ��������� ��������� �� ������� ��� ������
		//
		// ������������ ��������
		//  ������, ��������� ���������

		public object ������������������(/**/)
		{
		}
		// ���������� ��� ������� ���������� ��� �������� ����. �������
		//
		// ������������ ��������
		//	������  - ��� ������� ����������

		public object �����������������������(/**/)
		{
		}
		////////////////////////////////////////////////////////////////////////////////
		// ��������� - ����������� ������� �������
		// ���������� ������� ������������
		// ����������� �������� - ����� �������� ������� ��� ���.
		// ��� ������������� ��������� ������������ �������

		public void ������������(/*�����*/)
		{
			if(true/*������������.�������� ��� ���������*/)
			{
			}
			/*// �� �� ���� ���������� ����������� ���������
*/
			/*// ���� �� ����������� ���������, �� �� ����� ����� ����������� �������� ��� �������
*/
			if(true/*�� ����������������������������������.��������������������������������������_������������������(�����������������������)*/)
			{
				/*��������������    = ������;*/
				/*����������������� = ����;*/
			}
		}
	}
}
