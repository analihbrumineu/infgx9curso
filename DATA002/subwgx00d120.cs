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
   public class subwgx00d120 : GXSubfileElement
   {
      private int LocMidMidCodigo ;
      private int LocMidFilCodigo ;
      private int LocCodigo ;
      public int getLocMidMidCodigo( )
      {
         return LocMidMidCodigo ;
      }

      public void setLocMidMidCodigo( int value )
      {
         LocMidMidCodigo = value;
      }

      public int getLocMidFilCodigo( )
      {
         return LocMidFilCodigo ;
      }

      public void setLocMidFilCodigo( int value )
      {
         LocMidFilCodigo = value;
      }

      public int getLocCodigo( )
      {
         return LocCodigo ;
      }

      public void setLocCodigo( int value )
      {
         LocCodigo = value;
      }

      public override void clear( )
      {
         LocMidMidCodigo = 0 ;
         LocMidFilCodigo = 0 ;
         LocCodigo = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getLocMidMidCodigo() > ((subwgx00d120) element).getLocMidMidCodigo() ) return 1;
                  if ( getLocMidMidCodigo() < ((subwgx00d120) element).getLocMidMidCodigo() ) return -1;
                  return 0;
               case 1 :
                  if ( getLocMidFilCodigo() > ((subwgx00d120) element).getLocMidFilCodigo() ) return 1;
                  if ( getLocMidFilCodigo() < ((subwgx00d120) element).getLocMidFilCodigo() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getLocMidMidCodigo() == 0 ) && ( getLocMidFilCodigo() == 0 ) && ( getLocCodigo() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getLocMidMidCodigo() );
               break;
            case 1 :
               cell.setValue( getLocMidFilCodigo() );
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
               return ( (((GUIObjectInt) cell).getValue() == getLocMidMidCodigo()) );
            case 1 :
               return ( (((GUIObjectInt) cell).getValue() == getLocMidFilCodigo()) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setLocMidMidCodigo(value.getIntValue());
                  break;
               case 1 :
                  setLocMidFilCodigo(value.getIntValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setLocMidMidCodigo(((subwgx00d120) element).getLocMidMidCodigo());
                  return;
               case 1 :
                  setLocMidFilCodigo(((subwgx00d120) element).getLocMidFilCodigo());
                  return;
         }
      }

   }

}
