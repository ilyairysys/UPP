
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������;//��������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������//��������
{
	///<summary>
	///(���)
	///</summary>
	public partial class �����������������������:������������������
	{

		public static �����������������.����������������������� �����������(decimal ���)
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Select top 1 
					_IDRRef [������]
					,_Version [������]
					,_Marked [���������������]
					,_IsMetadata [����������������]
					,_Code [���]
					,_Description [������������]
					,_Fld2975 [�����������]
					,_Fld2976RRef [���������]
					,_Fld2977 [���������������]
					,_Fld2978RRef [������]
					,_Fld2979RRef [�������������������������]
					,_Fld2980 [������������������]
					,_Fld2981RRef [�����������������]
					,_Fld2982 [��������������������������]
					,_Fld2983 [����������]
					From _Reference167(NOLOCK)
					Where _Code=@���";
					�������.Parameters.AddWithValue("���", ���);
					using (var ������� = �������.ExecuteReader())
					{
						if (�������.Read())
						{
							var ������ = new �����������������.�����������������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.����������� = �������.GetString(6);
							������.��������� = V82.������������/*������*/.�����������������.������������.��������((byte[])�������.GetValue(7));
							������.��������������� = �������.GetDateTime(8);
							//������.������ = new V82.�����������������.������������((byte[])�������.GetValue(9));
							������.������������������������� = V82.������������/*������*/.�������������.������������.��������((byte[])�������.GetValue(10));
							������.������������������ = �������.GetDecimal(11);
							//������.����������������� = new V82.�����������������.��������������������((byte[])�������.GetValue(12));
							������.�������������������������� = �������.GetDecimal(13);
							������.���������� = �������.GetDecimal(14);
							return ������;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}

		public static ������������������.����������������������� �������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Select top 1000 
					_IDRRef [������]
					,_Version [������]
					,_Marked [���������������]
					,_IsMetadata [����������������]
					,_Code [���]
					,_Description [������������],_Fld2975 [�����������],_Fld2976RRef [���������],_Fld2977 [���������������],_Fld2978RRef [������],_Fld2979RRef [�������������������������],_Fld2980 [������������������],_Fld2981RRef [�����������������],_Fld2982 [��������������������������],_Fld2983 [����������]
		 From _Reference167(NOLOCK)";
					var ������� = new V82.������������������.�����������������������();
					using (var ������� = �������.ExecuteReader())
					{
						while (�������.Read())
						{
							var ������ = new �����������������.�����������������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.����������� = �������.GetString(6);
							������.��������� = V82.������������/*������*/.�����������������.������������.��������((byte[])�������.GetValue(7));
							������.��������������� = �������.GetDateTime(8);
							//������.������ = new V82.�����������������.������������((byte[])�������.GetValue(9));
							������.������������������������� = V82.������������/*������*/.�������������.������������.��������((byte[])�������.GetValue(10));
							������.������������������ = �������.GetDecimal(11);
							//������.����������������� = new V82.�����������������.��������������������((byte[])�������.GetValue(12));
							������.�������������������������� = �������.GetDecimal(13);
							������.���������� = �������.GetDecimal(14);
							�������.Add(������);
						}
							return �������;
					}
				}
			}
		}

		public static V82.�����������������.����������������������� ��������������()
		{
			var ������ = new V82.�����������������.�����������������������();
			������._�������� = true;
			������.������ = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			������.��������� = false;
			������.����������� = "";
			������.��������� = V82.������������/*������*/.�����������������.������������;
			������.������ = new V82.�����������������.������������();
			������.������������������������� = V82.������������/*������*/.�������������.������������;
			������.����������������� = new V82.�����������������.��������������������();
			return ������;
		}
	}
}
