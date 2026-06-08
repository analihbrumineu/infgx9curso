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
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class subwgx005111 : GXSubfileElement
   {
      private int FilAtoCodigo ;
      private short FilAtoProt ;
      private int FilCodigo ;
      public int getFilAtoCodigo( )
      {
         return FilAtoCodigo ;
      }

      public void setFilAtoCodigo( int value )
      {
         FilAtoCodigo = value;
      }

      public short getFilAtoProt( )
      {
         return FilAtoProt ;
      }

      public void setFilAtoProt( short value )
      {
         FilAtoProt = value;
      }

      public int getFilCodigo( )
      {
         return FilCodigo ;
      }

      public void setFilCodigo( int value )
      {
         FilCodigo = value;
      }

      public override void clear( )
      {
         FilAtoCodigo = 0 ;
         FilAtoProt = 0 ;
         FilCodigo = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getFilAtoCodigo() > ((subwgx005111) element).getFilAtoCodigo() ) return 1;
                  if ( getFilAtoCodigo() < ((subwgx005111) element).getFilAtoCodigo() ) return -1;
                  return 0;
               case 1 :
                  if ( getFilAtoProt() > ((subwgx005111) element).getFilAtoProt() ) return 1;
                  if ( getFilAtoProt() < ((subwgx005111) element).getFilAtoProt() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getFilAtoCodigo() == 0 ) && ( getFilAtoProt() == 0 ) && ( getFilCodigo() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getFilAtoCodigo() );
               break;
            case 1 :
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
                  setFilAtoCodigo(((subwgx005111) element).getFilAtoCodigo());
                  return;
               case 1 :
                  setFilAtoProt(((subwgx005111) element).getFilAtoProt());
                  return;
         }
      }

   }

}
