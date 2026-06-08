using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using com.genexus;
using com.genexus.ui;
using com.genexus.uifactory;
using GeneXus.Windows;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus.distributed;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class subtfilme27 : GXSubfileElement
   {
      private int FilAtoCodigo ;
      private String FilAtoNome ;
      private short FilAtoProt ;
      private short ZFilAtoProt ;
      public int getFilAtoCodigo( )
      {
         return FilAtoCodigo ;
      }

      public void setFilAtoCodigo( int value )
      {
         FilAtoCodigo = value;
      }

      public String getFilAtoNome( )
      {
         return FilAtoNome ;
      }

      public void setFilAtoNome( String value )
      {
         FilAtoNome = value;
      }

      public short getFilAtoProt( )
      {
         return FilAtoProt ;
      }

      public void setFilAtoProt( short value )
      {
         FilAtoProt = value;
      }

      public short getZFilAtoProt( )
      {
         return ZFilAtoProt ;
      }

      public void setZFilAtoProt( short value )
      {
         ZFilAtoProt = value;
      }

      public override void clear( )
      {
         FilAtoCodigo = 0 ;
         FilAtoNome = "" ;
         FilAtoProt = 0 ;
         ZFilAtoProt = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getFilAtoCodigo() > ((subtfilme27) element).getFilAtoCodigo() ) return 1;
                  if ( getFilAtoCodigo() < ((subtfilme27) element).getFilAtoCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getFilAtoNome().CompareTo(((subtfilme27) element).getFilAtoNome()) ;
               case 2 :
                  if ( getFilAtoProt() > ((subtfilme27) element).getFilAtoProt() ) return 1;
                  if ( getFilAtoProt() < ((subtfilme27) element).getFilAtoProt() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override int isChanged( )
      {
         return (!userModified && (!inserted
         && (ZFilAtoProt == FilAtoProt)
         ))?0:1;
      }

      public override bool isEmpty( )
      {
         return ( ( getFilAtoCodigo() == 0 ) && ( String.CompareOrdinal(getFilAtoNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getFilAtoProt() == 0 ) || insertedNotUserModified() )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getFilAtoCodigo() );
               break;
            case 1 :
               cell.setValue( getFilAtoNome() );
               break;
            case 2 :
               cell.setValue( getFilAtoProt() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( (((GUIObjectInt) cell).getValue() == getFilAtoCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getFilAtoNome()) == 0) );
            case 2 :
               return ( (((GUIObjectShort) cell).getValue() == getFilAtoProt()) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setFilAtoCodigo(value.getIntValue());
                  break;
               case 1 :
                  setFilAtoNome(value.getStringValue());
                  break;
               case 2 :
                  setFilAtoProt(value.getShortValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setFilAtoCodigo(((subtfilme27) element).getFilAtoCodigo());
                  return;
               case 1 :
                  setFilAtoNome(((subtfilme27) element).getFilAtoNome());
                  return;
               case 2 :
                  setFilAtoProt(((subtfilme27) element).getFilAtoProt());
                  return;
         }
      }

   }

}
