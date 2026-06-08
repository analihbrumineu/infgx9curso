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
   public class subwgx009016 : GXSubfileElement
   {
      private int MidCodigo ;
      private short MidTipo ;
      private String MidTipoDescription ;
      private short MidSituacao ;
      private String MidSituacaoDescription ;
      private int FilCodigo ;
      public int getMidCodigo( )
      {
         return MidCodigo ;
      }

      public void setMidCodigo( int value )
      {
         MidCodigo = value;
      }

      public short getMidTipo( )
      {
         return MidTipo ;
      }

      public void setMidTipo( short value )
      {
         MidTipo = value;
      }

      public String getMidTipoDescription( )
      {
         return MidTipoDescription ;
      }

      public void setMidTipoDescription( String value )
      {
         MidTipoDescription = value;
      }

      public short getMidSituacao( )
      {
         return MidSituacao ;
      }

      public void setMidSituacao( short value )
      {
         MidSituacao = value;
      }

      public String getMidSituacaoDescription( )
      {
         return MidSituacaoDescription ;
      }

      public void setMidSituacaoDescription( String value )
      {
         MidSituacaoDescription = value;
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
         MidCodigo = 0 ;
         MidTipo = 0 ;
         MidSituacao = 0 ;
         FilCodigo = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getMidCodigo() > ((subwgx009016) element).getMidCodigo() ) return 1;
                  if ( getMidCodigo() < ((subwgx009016) element).getMidCodigo() ) return -1;
                  return 0;
               case 1 :
                  if ( getMidTipo() > ((subwgx009016) element).getMidTipo() ) return 1;
                  if ( getMidTipo() < ((subwgx009016) element).getMidTipo() ) return -1;
                  return 0;
               case 2 :
                  if ( getMidSituacao() > ((subwgx009016) element).getMidSituacao() ) return 1;
                  if ( getMidSituacao() < ((subwgx009016) element).getMidSituacao() ) return -1;
                  return 0;
               case 3 :
                  if ( getFilCodigo() > ((subwgx009016) element).getFilCodigo() ) return 1;
                  if ( getFilCodigo() < ((subwgx009016) element).getFilCodigo() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getMidCodigo() == 0 ) && ( getMidTipo() == 0 ) && ( getMidSituacao() == 0 ) && ( getFilCodigo() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getMidCodigo() );
               break;
            case 1 :
               cell.setValue( getMidTipo() );
               break;
            case 2 :
               cell.setValue( getMidSituacao() );
               break;
            case 3 :
               cell.setValue( getFilCodigo() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 1 :
               return getMidTipoDescription() ;
            case 2 :
               return getMidSituacaoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( (((GUIObjectInt) cell).getValue() == getMidCodigo()) );
            case 1 :
               return ( (((GUIObjectShort) cell).getValue() == getMidTipo()) );
            case 2 :
               return ( (((GUIObjectShort) cell).getValue() == getMidSituacao()) );
            case 3 :
               return ( (((GUIObjectInt) cell).getValue() == getFilCodigo()) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setMidCodigo(value.getIntValue());
                  break;
               case 1 :
                  setMidTipo(value.getShortValue());
                  setMidTipoDescription( value.getText());
                  break;
               case 2 :
                  setMidSituacao(value.getShortValue());
                  setMidSituacaoDescription( value.getText());
                  break;
               case 3 :
                  setFilCodigo(value.getIntValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setMidCodigo(((subwgx009016) element).getMidCodigo());
                  return;
               case 1 :
                  setMidTipo(((subwgx009016) element).getMidTipo());
                  setMidTipoDescription(((subwgx009016) element).getMidTipoDescription());
                  return;
               case 2 :
                  setMidSituacao(((subwgx009016) element).getMidSituacao());
                  setMidSituacaoDescription(((subwgx009016) element).getMidSituacaoDescription());
                  return;
               case 3 :
                  setFilCodigo(((subwgx009016) element).getFilCodigo());
                  return;
         }
      }

   }

}
