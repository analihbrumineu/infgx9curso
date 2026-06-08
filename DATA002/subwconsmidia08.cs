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
   public class subwconsmidia08 : GXSubfileElement
   {
      private int MidCodigo ;
      private int FilCodigo ;
      private String FilNome ;
      private String CatNome ;
      private DateTime FilData ;
      private short MidTipo ;
      private String MidTipoDescription ;
      private short MidSituacao ;
      private String MidSituacaoDescription ;
      private decimal ConfTipValor ;
      private int VFilAtoCodigo ;
      private String VFilAtoNome ;
      private int VFilDirCodigo ;
      private String VFilDirNome ;
      public int getMidCodigo( )
      {
         return MidCodigo ;
      }

      public void setMidCodigo( int value )
      {
         MidCodigo = value;
      }

      public int getFilCodigo( )
      {
         return FilCodigo ;
      }

      public void setFilCodigo( int value )
      {
         FilCodigo = value;
      }

      public String getFilNome( )
      {
         return FilNome ;
      }

      public void setFilNome( String value )
      {
         FilNome = value;
      }

      public String getCatNome( )
      {
         return CatNome ;
      }

      public void setCatNome( String value )
      {
         CatNome = value;
      }

      public DateTime getFilData( )
      {
         return FilData ;
      }

      public void setFilData( DateTime value )
      {
         FilData = value;
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

      public decimal getConfTipValor( )
      {
         return ConfTipValor ;
      }

      public void setConfTipValor( decimal value )
      {
         ConfTipValor = value;
      }

      public int getVFilAtoCodigo( )
      {
         return VFilAtoCodigo ;
      }

      public void setVFilAtoCodigo( int value )
      {
         VFilAtoCodigo = value;
      }

      public String getVFilAtoNome( )
      {
         return VFilAtoNome ;
      }

      public void setVFilAtoNome( String value )
      {
         VFilAtoNome = value;
      }

      public int getVFilDirCodigo( )
      {
         return VFilDirCodigo ;
      }

      public void setVFilDirCodigo( int value )
      {
         VFilDirCodigo = value;
      }

      public String getVFilDirNome( )
      {
         return VFilDirNome ;
      }

      public void setVFilDirNome( String value )
      {
         VFilDirNome = value;
      }

      public override void clear( )
      {
         MidCodigo = 0 ;
         FilCodigo = 0 ;
         FilNome = "" ;
         CatNome = "" ;
         FilData = DateTime.MinValue ;
         MidTipo = 0 ;
         MidSituacao = 0 ;
         ConfTipValor = 0M ;
         VFilAtoCodigo = 0 ;
         VFilAtoNome = "" ;
         VFilDirCodigo = 0 ;
         VFilDirNome = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getMidCodigo() > ((subwconsmidia08) element).getMidCodigo() ) return 1;
                  if ( getMidCodigo() < ((subwconsmidia08) element).getMidCodigo() ) return -1;
                  return 0;
               case 1 :
                  if ( getFilCodigo() > ((subwconsmidia08) element).getFilCodigo() ) return 1;
                  if ( getFilCodigo() < ((subwconsmidia08) element).getFilCodigo() ) return -1;
                  return 0;
               case 2 :
                  return  getFilNome().CompareTo(((subwconsmidia08) element).getFilNome()) ;
               case 3 :
                  return  getCatNome().CompareTo(((subwconsmidia08) element).getCatNome()) ;
               case 4 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getFilData()) , GxConvert.AnyDateToJDate(((subwconsmidia08) element).getFilData()) );
               case 5 :
                  if ( getMidTipo() > ((subwconsmidia08) element).getMidTipo() ) return 1;
                  if ( getMidTipo() < ((subwconsmidia08) element).getMidTipo() ) return -1;
                  return 0;
               case 6 :
                  if ( getMidSituacao() > ((subwconsmidia08) element).getMidSituacao() ) return 1;
                  if ( getMidSituacao() < ((subwconsmidia08) element).getMidSituacao() ) return -1;
                  return 0;
               case 7 :
                  if ( getConfTipValor() > ((subwconsmidia08) element).getConfTipValor() ) return 1;
                  if ( getConfTipValor() < ((subwconsmidia08) element).getConfTipValor() ) return -1;
                  return 0;
               case 8 :
                  if ( getVFilAtoCodigo() > ((subwconsmidia08) element).getVFilAtoCodigo() ) return 1;
                  if ( getVFilAtoCodigo() < ((subwconsmidia08) element).getVFilAtoCodigo() ) return -1;
                  return 0;
               case 9 :
                  return  getVFilAtoNome().CompareTo(((subwconsmidia08) element).getVFilAtoNome()) ;
               case 10 :
                  if ( getVFilDirCodigo() > ((subwconsmidia08) element).getVFilDirCodigo() ) return 1;
                  if ( getVFilDirCodigo() < ((subwconsmidia08) element).getVFilDirCodigo() ) return -1;
                  return 0;
               case 11 :
                  return  getVFilDirNome().CompareTo(((subwconsmidia08) element).getVFilDirNome()) ;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getMidCodigo() == 0 ) && ( getFilCodigo() == 0 ) && ( String.CompareOrdinal(getFilNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getCatNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getFilData() == DateTime.MinValue ) && ( getMidTipo() == 0 ) && ( getMidSituacao() == 0 ) && ( getConfTipValor() == Convert.ToDecimal( 0M )) && ( getVFilAtoCodigo() == 0 ) && ( String.CompareOrdinal(getVFilAtoNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getVFilDirCodigo() == 0 ) && ( String.CompareOrdinal(getVFilDirNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getMidCodigo() );
               break;
            case 1 :
               cell.setValue( getFilCodigo() );
               break;
            case 2 :
               cell.setValue( getFilNome() );
               break;
            case 3 :
               cell.setValue( getCatNome() );
               break;
            case 4 :
               cell.setValue( GxConvert.AnyDateToJDate(getFilData()) );
               break;
            case 5 :
               cell.setValue( getMidTipo() );
               break;
            case 6 :
               cell.setValue( getMidSituacao() );
               break;
            case 7 :
               cell.setValue( GxConvert.AnyDecimalToJDecimal(getConfTipValor()) );
               break;
            case 8 :
               cell.setValue( getVFilAtoCodigo() );
               break;
            case 9 :
               cell.setValue( getVFilAtoNome() );
               break;
            case 10 :
               cell.setValue( getVFilDirCodigo() );
               break;
            case 11 :
               cell.setValue( getVFilDirNome() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 5 :
               return getMidTipoDescription() ;
            case 6 :
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
               return ( (((GUIObjectInt) cell).getValue() == getFilCodigo()) );
            case 2 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getFilNome()) == 0) );
            case 3 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getCatNome()) == 0) );
            case 4 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getFilData()))) );
            case 5 :
               return ( (((GUIObjectShort) cell).getValue() == getMidTipo()) );
            case 6 :
               return ( (((GUIObjectShort) cell).getValue() == getMidSituacao()) );
            case 7 :
               return ( (((GUIObjectDecimal2) cell).getValue() == getConfTipValor()) );
            case 8 :
               return ( (((GUIObjectInt) cell).getValue() == getVFilAtoCodigo()) );
            case 9 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVFilAtoNome()) == 0) );
            case 10 :
               return ( (((GUIObjectInt) cell).getValue() == getVFilDirCodigo()) );
            case 11 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVFilDirNome()) == 0) );
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
                  setFilCodigo(value.getIntValue());
                  break;
               case 2 :
                  setFilNome(value.getStringValue());
                  break;
               case 3 :
                  setCatNome(value.getStringValue());
                  break;
               case 4 :
                  setFilData(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
               case 5 :
                  setMidTipo(value.getShortValue());
                  setMidTipoDescription( value.getText());
                  break;
               case 6 :
                  setMidSituacao(value.getShortValue());
                  setMidSituacaoDescription( value.getText());
                  break;
               case 7 :
                  setConfTipValor(GxConvert.AnyDecimalToDecimal(value.getDecimalValue()));
                  break;
               case 8 :
                  setVFilAtoCodigo(value.getIntValue());
                  break;
               case 9 :
                  setVFilAtoNome(value.getStringValue());
                  break;
               case 10 :
                  setVFilDirCodigo(value.getIntValue());
                  break;
               case 11 :
                  setVFilDirNome(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setMidCodigo(((subwconsmidia08) element).getMidCodigo());
                  return;
               case 1 :
                  setFilCodigo(((subwconsmidia08) element).getFilCodigo());
                  return;
               case 2 :
                  setFilNome(((subwconsmidia08) element).getFilNome());
                  return;
               case 3 :
                  setCatNome(((subwconsmidia08) element).getCatNome());
                  return;
               case 4 :
                  setFilData(((subwconsmidia08) element).getFilData());
                  return;
               case 5 :
                  setMidTipo(((subwconsmidia08) element).getMidTipo());
                  setMidTipoDescription(((subwconsmidia08) element).getMidTipoDescription());
                  return;
               case 6 :
                  setMidSituacao(((subwconsmidia08) element).getMidSituacao());
                  setMidSituacaoDescription(((subwconsmidia08) element).getMidSituacaoDescription());
                  return;
               case 7 :
                  setConfTipValor(((subwconsmidia08) element).getConfTipValor());
                  return;
               case 8 :
                  setVFilAtoCodigo(((subwconsmidia08) element).getVFilAtoCodigo());
                  return;
               case 9 :
                  setVFilAtoNome(((subwconsmidia08) element).getVFilAtoNome());
                  return;
               case 10 :
                  setVFilDirCodigo(((subwconsmidia08) element).getVFilDirCodigo());
                  return;
               case 11 :
                  setVFilDirNome(((subwconsmidia08) element).getVFilDirNome());
                  return;
         }
      }

   }

}
