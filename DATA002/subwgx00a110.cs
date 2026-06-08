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
   public class subwgx00a110 : GXSubfileElement
   {
      private int FilDirCodigo ;
      private int FilCodigo ;
      public int getFilDirCodigo( )
      {
         return FilDirCodigo ;
      }

      public void setFilDirCodigo( int value )
      {
         FilDirCodigo = value;
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
         FilDirCodigo = 0 ;
         FilCodigo = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getFilDirCodigo() > ((subwgx00a110) element).getFilDirCodigo() ) return 1;
                  if ( getFilDirCodigo() < ((subwgx00a110) element).getFilDirCodigo() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getFilDirCodigo() == 0 ) && ( getFilCodigo() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getFilDirCodigo() );
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
               return ( (((GUIObjectInt) cell).getValue() == getFilDirCodigo()) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setFilDirCodigo(value.getIntValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setFilDirCodigo(((subwgx00a110) element).getFilDirCodigo());
                  return;
         }
      }

   }

}
