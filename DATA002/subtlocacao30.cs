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
   public class subtlocacao30 : GXSubfileElement
   {
      private int LocMidMidCodigo ;
      private String LocMidFilNome ;
      private short LocMidMidTipo ;
      private String LocMidMidTipoDescription ;
      private decimal LocMidMidConfValor ;
      private int LocMidFilCodigo ;
      private int LocMidCatCodigo ;
      private short LocMidMidSituacao ;
      private int LocMidMidLocCodigo ;
      private int ZLocMidFilCodigo ;
      private String ZLocMidFilNome ;
      private int ZLocMidCatCodigo ;
      private short ZLocMidMidTipo ;
      private int ZLocMidMidLocCodigo ;
      private decimal ZLocMidMidConfValor ;
      public int getLocMidMidCodigo( )
      {
         return LocMidMidCodigo ;
      }

      public void setLocMidMidCodigo( int value )
      {
         LocMidMidCodigo = value;
      }

      public String getLocMidFilNome( )
      {
         return LocMidFilNome ;
      }

      public void setLocMidFilNome( String value )
      {
         LocMidFilNome = value;
      }

      public short getLocMidMidTipo( )
      {
         return LocMidMidTipo ;
      }

      public void setLocMidMidTipo( short value )
      {
         LocMidMidTipo = value;
      }

      public String getLocMidMidTipoDescription( )
      {
         return LocMidMidTipoDescription ;
      }

      public void setLocMidMidTipoDescription( String value )
      {
         LocMidMidTipoDescription = value;
      }

      public decimal getLocMidMidConfValor( )
      {
         return LocMidMidConfValor ;
      }

      public void setLocMidMidConfValor( decimal value )
      {
         LocMidMidConfValor = value;
      }

      public int getLocMidFilCodigo( )
      {
         return LocMidFilCodigo ;
      }

      public void setLocMidFilCodigo( int value )
      {
         LocMidFilCodigo = value;
      }

      public int getLocMidCatCodigo( )
      {
         return LocMidCatCodigo ;
      }

      public void setLocMidCatCodigo( int value )
      {
         LocMidCatCodigo = value;
      }

      public short getLocMidMidSituacao( )
      {
         return LocMidMidSituacao ;
      }

      public void setLocMidMidSituacao( short value )
      {
         LocMidMidSituacao = value;
      }

      public int getLocMidMidLocCodigo( )
      {
         return LocMidMidLocCodigo ;
      }

      public void setLocMidMidLocCodigo( int value )
      {
         LocMidMidLocCodigo = value;
      }

      public int getZLocMidFilCodigo( )
      {
         return ZLocMidFilCodigo ;
      }

      public void setZLocMidFilCodigo( int value )
      {
         ZLocMidFilCodigo = value;
      }

      public String getZLocMidFilNome( )
      {
         return ZLocMidFilNome ;
      }

      public void setZLocMidFilNome( String value )
      {
         ZLocMidFilNome = value;
      }

      public int getZLocMidCatCodigo( )
      {
         return ZLocMidCatCodigo ;
      }

      public void setZLocMidCatCodigo( int value )
      {
         ZLocMidCatCodigo = value;
      }

      public short getZLocMidMidTipo( )
      {
         return ZLocMidMidTipo ;
      }

      public void setZLocMidMidTipo( short value )
      {
         ZLocMidMidTipo = value;
      }

      public int getZLocMidMidLocCodigo( )
      {
         return ZLocMidMidLocCodigo ;
      }

      public void setZLocMidMidLocCodigo( int value )
      {
         ZLocMidMidLocCodigo = value;
      }

      public decimal getZLocMidMidConfValor( )
      {
         return ZLocMidMidConfValor ;
      }

      public void setZLocMidMidConfValor( decimal value )
      {
         ZLocMidMidConfValor = value;
      }

      public override void clear( )
      {
         LocMidMidCodigo = 0 ;
         LocMidFilNome = "" ;
         LocMidMidTipo = 0 ;
         LocMidMidConfValor = 0M ;
         LocMidFilCodigo = 0 ;
         LocMidCatCodigo = 0 ;
         LocMidMidSituacao = 0 ;
         LocMidMidLocCodigo = 0 ;
         ZLocMidFilCodigo = 0 ;
         ZLocMidFilNome = "" ;
         ZLocMidCatCodigo = 0 ;
         ZLocMidMidTipo = 0 ;
         ZLocMidMidLocCodigo = 0 ;
         ZLocMidMidConfValor = 0M ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getLocMidMidCodigo() > ((subtlocacao30) element).getLocMidMidCodigo() ) return 1;
                  if ( getLocMidMidCodigo() < ((subtlocacao30) element).getLocMidMidCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getLocMidFilNome().CompareTo(((subtlocacao30) element).getLocMidFilNome()) ;
               case 2 :
                  if ( getLocMidMidTipo() > ((subtlocacao30) element).getLocMidMidTipo() ) return 1;
                  if ( getLocMidMidTipo() < ((subtlocacao30) element).getLocMidMidTipo() ) return -1;
                  return 0;
               case 3 :
                  if ( getLocMidMidConfValor() > ((subtlocacao30) element).getLocMidMidConfValor() ) return 1;
                  if ( getLocMidMidConfValor() < ((subtlocacao30) element).getLocMidMidConfValor() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override int isChanged( )
      {
         return (!userModified && (!inserted
         && ( GXutil.strcmp(ZLocMidFilNome,LocMidFilNome) == 0)
         && (ZLocMidMidTipo == LocMidMidTipo)
         && (ZLocMidMidConfValor == LocMidMidConfValor)
         && (ZLocMidFilCodigo == LocMidFilCodigo)
         && (ZLocMidCatCodigo == LocMidCatCodigo)
         && (ZLocMidMidLocCodigo == LocMidMidLocCodigo)
         ))?0:1;
      }

      public override bool isEmpty( )
      {
         return ( ( getLocMidMidCodigo() == 0 ) && ( String.CompareOrdinal(getLocMidFilNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getLocMidMidTipo() == 0 ) && ( getLocMidMidConfValor() == Convert.ToDecimal( 0M )) && ( getLocMidFilCodigo() == 0 ) && ( getLocMidCatCodigo() == 0 ) && ( getLocMidMidSituacao() == 0 ) && ( getLocMidMidLocCodigo() == 0 ) || insertedNotUserModified() )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getLocMidMidCodigo() );
               break;
            case 1 :
               cell.setValue( getLocMidFilNome() );
               break;
            case 2 :
               cell.setValue( getLocMidMidTipo() );
               break;
            case 3 :
               cell.setValue( GxConvert.AnyDecimalToJDecimal(getLocMidMidConfValor()) );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 2 :
               return getLocMidMidTipoDescription() ;
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
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getLocMidFilNome()) == 0) );
            case 2 :
               return ( (((GUIObjectShort) cell).getValue() == getLocMidMidTipo()) );
            case 3 :
               return ( (((GUIObjectDecimal2) cell).getValue() == getLocMidMidConfValor()) );
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
                  setLocMidFilNome(value.getStringValue());
                  break;
               case 2 :
                  setLocMidMidTipo(value.getShortValue());
                  setLocMidMidTipoDescription( value.getText());
                  break;
               case 3 :
                  setLocMidMidConfValor(GxConvert.AnyDecimalToDecimal(value.getDecimalValue()));
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setLocMidMidCodigo(((subtlocacao30) element).getLocMidMidCodigo());
                  return;
               case 1 :
                  setLocMidFilNome(((subtlocacao30) element).getLocMidFilNome());
                  return;
               case 2 :
                  setLocMidMidTipo(((subtlocacao30) element).getLocMidMidTipo());
                  setLocMidMidTipoDescription(((subtlocacao30) element).getLocMidMidTipoDescription());
                  return;
               case 3 :
                  setLocMidMidConfValor(((subtlocacao30) element).getLocMidMidConfValor());
                  return;
         }
      }

   }

}
