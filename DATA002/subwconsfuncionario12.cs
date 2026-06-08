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
   public class subwconsfuncionario12 : GXSubfileElement
   {
      private int PesCodigo ;
      private String PesNome ;
      private short PesFunCargo ;
      private String PesFunCargoDescription ;
      private DateTime PesFunDatDemissao ;
      private short VDemitido ;
      public int getPesCodigo( )
      {
         return PesCodigo ;
      }

      public void setPesCodigo( int value )
      {
         PesCodigo = value;
      }

      public String getPesNome( )
      {
         return PesNome ;
      }

      public void setPesNome( String value )
      {
         PesNome = value;
      }

      public short getPesFunCargo( )
      {
         return PesFunCargo ;
      }

      public void setPesFunCargo( short value )
      {
         PesFunCargo = value;
      }

      public String getPesFunCargoDescription( )
      {
         return PesFunCargoDescription ;
      }

      public void setPesFunCargoDescription( String value )
      {
         PesFunCargoDescription = value;
      }

      public DateTime getPesFunDatDemissao( )
      {
         return PesFunDatDemissao ;
      }

      public void setPesFunDatDemissao( DateTime value )
      {
         PesFunDatDemissao = value;
      }

      public short getVDemitido( )
      {
         return VDemitido ;
      }

      public void setVDemitido( short value )
      {
         VDemitido = value;
      }

      public override void clear( )
      {
         PesCodigo = 0 ;
         PesNome = "" ;
         PesFunCargo = 0 ;
         PesFunDatDemissao = DateTime.MinValue ;
         VDemitido = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getPesCodigo() > ((subwconsfuncionario12) element).getPesCodigo() ) return 1;
                  if ( getPesCodigo() < ((subwconsfuncionario12) element).getPesCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getPesNome().CompareTo(((subwconsfuncionario12) element).getPesNome()) ;
               case 2 :
                  if ( getPesFunCargo() > ((subwconsfuncionario12) element).getPesFunCargo() ) return 1;
                  if ( getPesFunCargo() < ((subwconsfuncionario12) element).getPesFunCargo() ) return -1;
                  return 0;
               case 3 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getPesFunDatDemissao()) , GxConvert.AnyDateToJDate(((subwconsfuncionario12) element).getPesFunDatDemissao()) );
               case 4 :
                  if ( getVDemitido() > ((subwconsfuncionario12) element).getVDemitido() ) return 1;
                  if ( getVDemitido() < ((subwconsfuncionario12) element).getVDemitido() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getPesCodigo() == 0 ) && ( String.CompareOrdinal(getPesNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getPesFunCargo() == 0 ) && ( getPesFunDatDemissao() == DateTime.MinValue ) && ( getVDemitido() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getPesCodigo() );
               break;
            case 1 :
               cell.setValue( getPesNome() );
               break;
            case 2 :
               cell.setValue( getPesFunCargo() );
               break;
            case 3 :
               cell.setValue( GxConvert.AnyDateToJDate(getPesFunDatDemissao()) );
               break;
            case 4 :
               cell.setValue( getVDemitido() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 2 :
               return getPesFunCargoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( (((GUIObjectInt) cell).getValue() == getPesCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getPesNome()) == 0) );
            case 2 :
               return ( (((GUIObjectShort) cell).getValue() == getPesFunCargo()) );
            case 3 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getPesFunDatDemissao()))) );
            case 4 :
               return ( (((GUIObjectShort) cell).getValue() == getVDemitido()) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setPesCodigo(value.getIntValue());
                  break;
               case 1 :
                  setPesNome(value.getStringValue());
                  break;
               case 2 :
                  setPesFunCargo(value.getShortValue());
                  setPesFunCargoDescription( value.getText());
                  break;
               case 3 :
                  setPesFunDatDemissao(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
               case 4 :
                  setVDemitido(value.getShortValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setPesCodigo(((subwconsfuncionario12) element).getPesCodigo());
                  return;
               case 1 :
                  setPesNome(((subwconsfuncionario12) element).getPesNome());
                  return;
               case 2 :
                  setPesFunCargo(((subwconsfuncionario12) element).getPesFunCargo());
                  setPesFunCargoDescription(((subwconsfuncionario12) element).getPesFunCargoDescription());
                  return;
               case 3 :
                  setPesFunDatDemissao(((subwconsfuncionario12) element).getPesFunDatDemissao());
                  return;
               case 4 :
                  setVDemitido(((subwconsfuncionario12) element).getVDemitido());
                  return;
         }
      }

   }

}
