
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
	public partial class ����������������������:������������������
	{

		public static �����������������.���������������������� �����������(decimal ���)
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
					,_Fld3333RRef [������]
					,_Fld3334 [������������������]
					,_Fld3335 [���������������������]
					,_Fld3336RRef [��������������������]
					,_Fld3337RRef [�������������������]
					,_Fld3338RRef [�������������]
					,_Fld3339RRef [������������������������]
					,_Fld3340RRef [���������]
					,_Fld3341RRef [��������������]
					,_Fld3342RRef [������������]
					,_Fld3343RRef [������]
					,_Fld3344RRef [����������1]
					,_Fld3345RRef [����������2]
					,_Fld3346RRef [����������3]
					,_Fld3347RRef [������]
					,_Fld3348RRef [����������1]
					,_Fld3349RRef [����������2]
					,_Fld3350RRef [����������3]
					,_Fld3351 [�����]
					,_Fld3352RRef [�����������������������]
					,_Fld3353RRef [�����������������������]
					,_Fld3354RRef [���������������������������������]
					,_Fld3355RRef [�������������������]
					,_Fld3356RRef [���������]
					From _Reference216(NOLOCK)
					Where _Code=@���";
					�������.Parameters.AddWithValue("���", ���);
					using (var ������� = �������.ExecuteReader())
					{
						if (�������.Read())
						{
							var ������ = new �����������������.����������������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.������ = V82.������������/*������*/.�������.������������.��������((byte[])�������.GetValue(6));
							������.������������������ = �������.GetDateTime(7);
							������.��������������������� = �������.GetDateTime(8);
							//������.�������������������� = new V82.�����������������.��������������������((byte[])�������.GetValue(9));
							//������.������������������� = new V82.�����������������.��������������������((byte[])�������.GetValue(10));
							//������.������������� = new V82.�����������������.�������������((byte[])�������.GetValue(11));
							//������.������������������������ = new V82.�����������������.������������������������((byte[])�������.GetValue(12));
							//������.��������� = new V82.�����������������.������������((byte[])�������.GetValue(13));
							//������.�������������� = new V82.�����������������.�����������������((byte[])�������.GetValue(14));
							//������.������������ = new V82.�����������������.������������((byte[])�������.GetValue(15));
							������.����� = �������.GetDecimal(24);
							//������.����������������������� = new V82.�����������������.��������������������������((byte[])�������.GetValue(25));
							������.����������������������� = V82.������������/*������*/.������������������������.������������.��������((byte[])�������.GetValue(26));
							//������.��������������������������������� = new V82.�����������������.����������������������������������((byte[])�������.GetValue(27));
							������.������������������� = V82.������������/*������*/.��������������������.������������.��������((byte[])�������.GetValue(28));
							������.��������� = V82.������������/*������*/.�����������������.������������.��������((byte[])�������.GetValue(29));
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

		public static ������������������.���������������������� �������()
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
					,_Description [������������],_Fld3333RRef [������],_Fld3334 [������������������],_Fld3335 [���������������������],_Fld3336RRef [��������������������],_Fld3337RRef [�������������������],_Fld3338RRef [�������������],_Fld3339RRef [������������������������],_Fld3340RRef [���������],_Fld3341RRef [��������������],_Fld3342RRef [������������],_Fld3343RRef [������],_Fld3344RRef [����������1],_Fld3345RRef [����������2],_Fld3346RRef [����������3],_Fld3347RRef [������],_Fld3348RRef [����������1],_Fld3349RRef [����������2],_Fld3350RRef [����������3],_Fld3351 [�����],_Fld3352RRef [�����������������������],_Fld3353RRef [�����������������������],_Fld3354RRef [���������������������������������],_Fld3355RRef [�������������������],_Fld3356RRef [���������]
		 From _Reference216(NOLOCK)";
					var ������� = new V82.������������������.����������������������();
					using (var ������� = �������.ExecuteReader())
					{
						while (�������.Read())
						{
							var ������ = new �����������������.����������������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.������ = V82.������������/*������*/.�������.������������.��������((byte[])�������.GetValue(6));
							������.������������������ = �������.GetDateTime(7);
							������.��������������������� = �������.GetDateTime(8);
							//������.�������������������� = new V82.�����������������.��������������������((byte[])�������.GetValue(9));
							//������.������������������� = new V82.�����������������.��������������������((byte[])�������.GetValue(10));
							//������.������������� = new V82.�����������������.�������������((byte[])�������.GetValue(11));
							//������.������������������������ = new V82.�����������������.������������������������((byte[])�������.GetValue(12));
							//������.��������� = new V82.�����������������.������������((byte[])�������.GetValue(13));
							//������.�������������� = new V82.�����������������.�����������������((byte[])�������.GetValue(14));
							//������.������������ = new V82.�����������������.������������((byte[])�������.GetValue(15));
							������.����� = �������.GetDecimal(24);
							//������.����������������������� = new V82.�����������������.��������������������������((byte[])�������.GetValue(25));
							������.����������������������� = V82.������������/*������*/.������������������������.������������.��������((byte[])�������.GetValue(26));
							//������.��������������������������������� = new V82.�����������������.����������������������������������((byte[])�������.GetValue(27));
							������.������������������� = V82.������������/*������*/.��������������������.������������.��������((byte[])�������.GetValue(28));
							������.��������� = V82.������������/*������*/.�����������������.������������.��������((byte[])�������.GetValue(29));
							�������.Add(������);
						}
							return �������;
					}
				}
			}
		}

		public static V82.�����������������.���������������������� ��������������()
		{
			var ������ = new V82.�����������������.����������������������();
			������._�������� = true;
			������.������ = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			������.��������� = false;
			������.������ = V82.������������/*������*/.�������.������������;
			������.�������������������� = new V82.�����������������.��������������������();
			������.������������������� = new V82.�����������������.��������������������();
			������.������������� = new V82.�����������������.�������������();
			������.������������������������ = new V82.�����������������.������������������������();
			������.��������� = new V82.�����������������.������������();
			������.�������������� = new V82.�����������������.�����������������();
			������.������������ = new V82.�����������������.������������();
			������.����������������������� = new V82.�����������������.��������������������������();
			������.����������������������� = V82.������������/*������*/.������������������������.������������;
			������.��������������������������������� = new V82.�����������������.����������������������������������();
			������.������������������� = V82.������������/*������*/.��������������������.������������;
			������.��������� = V82.������������/*������*/.�����������������.������������;
			return ������;
		}
	}
}
