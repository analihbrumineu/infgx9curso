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
   public class subwgx008010 : GXSubfileElement
   {
      private int CidCodigo ;
      private int EstCodigo ;
      public int getCidCodigo( )
      {
         return CidCodigo ;
      }

      public void setCidCodigo( int value )
      {
         CidCodigo = value;
      }

      public int getEstCodigo( )
      {
         return EstCodigo ;
      }

      public void setEstCodigo( int value )
      {
         EstCodigo = value;
      }

      public override void clear( )
      {
         CidCodigo = 0 ;
         EstCodigo = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getCidCodigo() > ((subwgx008010) element).getCidCodigo() ) return 1;
                  if ( getCidCodigo() < ((subwgx008010) element).getCidCodigo() ) return -1;
                  return 0;
               case 1 :
                  if ( getEstCodigo() > ((subwgx008010) element).getEstCodigo() ) return 1;
                  if ( getEstCodigo() < ((subwgx008010) element).getEstCodigo() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getCidCodigo() == 0 ) && ( getEstCodigo() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getCidCodigo() );
               break;
            case 1 :
               cell.setValue( getEstCodigo() );
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
               return ( (((GUIObjectInt) cell).getValue() == getCidCodigo()) );
            case 1 :
               return ( (((GUIObjectInt) cell).getValue() == getEstCodigo()) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setCidCodigo(value.getIntValue());
                  break;
               case 1 :
                  setEstCodigo(value.getIntValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setCidCodigo(((subwgx008010) element).getCidCodigo());
                  return;
               case 1 :
                  setEstCodigo(((subwgx008010) element).getEstCodigo());
                  return;
         }
      }

   }

}
