/*
               File: PeLocacao
        Description: Cadastro de locação.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 9:2:25.44
       Program type: Callable routine
          Main DBMS: sqlserver
*/
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
   public class wpelocacao : GXWorkpanel
   {
      public wpelocacao( int hnd ,
                         ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wpelocacao( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wpelocacao( IGxContext context ,
                         int hnd ,
                         ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "PeLocacao" ;
      }

      public override String getFrmTitle( )
      {
         return "Locações" ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return null;
      }

      public override bool useCallersMenuBar( )
      {
         return true;
      }

      public override int getFrmTop( )
      {
         return 0 ;
      }

      public override int getFrmLeft( )
      {
         return 0 ;
      }

      public override int getFrmWidth( )
      {
         return 910 ;
      }

      public override int getFrmHeight( )
      {
         return 832 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WPeLocacao.htm";
      }

      public override int getFrmBackground( )
      {
         return UIFactory.getColor(15) ;
      }

      public override int getFrmForeground( )
      {
         return UIFactory.getColor(6) ;
      }

      public override bool isMainProgram( )
      {
         return IsMain;
      }

      public override bool isModal( )
      {
         return false;
      }

      protected bool hasDBAccess( )
      {
         return true ;
      }

      public override int getRefreshTimeout( )
      {
         return 0 ;
      }

      public override bool getRefreshTimeoutAlways( )
      {
         return true ;
      }

      public override bool getPaintAfterStart( )
      {
         return true ;
      }

      public override int getBorderStyle( )
      {
         return 2 ;
      }

      public override bool getMaxButton( )
      {
         return true ;
      }

      public override bool getMinButton( )
      {
         return true ;
      }

      public override bool getCtrlBox( )
      {
         return true ;
      }

      public override bool getShowInTaskbar( )
      {
         return true ;
      }

      public override String getFormIcon( )
      {
         return "" ;
      }

      public override bool getAutocenter( )
      {
         return false ;
      }

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load10( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwpelocacao10 = new subwpelocacao10 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV5LocCliP ,
                                              AV6LocCliP ,
                                              AV7LocDatL ,
                                              AV8LocSitu ,
                                              A91LocCliP ,
                                              A92LocCliP ,
                                              A88LocDatL ,
                                              A87LocSitu },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W00262 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf10.getSize() < 10000 ) ) )
         {
            A87LocSitu = W00262_A87LocSitu[0] ;
            n87LocSitu = W00262_n87LocSitu[0] ;
            A92LocCliP = W00262_A92LocCliP[0] ;
            n92LocCliP = W00262_n92LocCliP[0] ;
            A91LocCliP = W00262_A91LocCliP[0] ;
            n91LocCliP = W00262_n91LocCliP[0] ;
            A88LocDatL = W00262_A88LocDatL[0] ;
            n88LocDatL = W00262_n88LocDatL[0] ;
            A86LocCodi = W00262_A86LocCodi[0] ;
            A92LocCliP = W00262_A92LocCliP[0] ;
            n92LocCliP = W00262_n92LocCliP[0] ;
            /* Execute user event: E11V262 */
            E11V262 ();
            pr_default.readNext(0);
         }
         if ( subGxsf10.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class PeLocacao_load10 : GXLoadProducer
      {
         wpelocacao _sf ;

         public PeLocacao_load10( wpelocacao uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer10();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load10();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors10();
         }

      }

      public override void GXRefresh( )
      {
         ControlsToVariables();
         GXRefreshCommand();
      }

      protected void GXRefreshCommand( )
      {
         if ( ! gxIsRefreshing )
         {
            gxIsRefreshing = true ;
            ControlsToVariables();
            standAlone();
            VariablesToControls();
            subGxsf10.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow10( )
      {
         return true;
      }

      public void autoRefresh_flow10( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow10() )) {
            subfile.refresh();
            resetSubfileConditions_flow10() ;
         }
      }

      public bool getSearch_flow10( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow10( )
      {
      }

      public void resetSearchConditions_flow10( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow10( )
      {
         return new subwpelocacao10 ();
      }

      public bool getSearch_flow10( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow10( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow10( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow10( )
      {
         GXRefreshCommand10 ();
      }

      public class PeLocacao_flow10 : GXSubfileFlow
      {
         wpelocacao _sf ;

         public PeLocacao_flow10( wpelocacao uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow10();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow10(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow10();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow10();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow10(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow10();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow10(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow10(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow10(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow10();
         }

      }

      protected void GXRefreshCommand10( )
      {
         ControlsToVariables();
         /* Execute user event: E12V262 */
         E12V262 ();
         /* End function GeneXus Refresh */
      }

      public override void GXStart( )
      {
         /* Execute user event: E13V262 */
         E13V262 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E13V262( )
      {
         eventNoLevelContext();
         /* Start Routine */
         AV8LocSitu = 0 ;
         cmbavLocsituacao.setValue(AV8LocSitu);
      }

      protected void E12V262( )
      {
         /* Refresh Routine */
         if ( ( AV5LocCliP < 0 ) )
         {
            GXutil.msg( me(), "Digite um código válido!" );
         }
         else
         {
            if ( ( AV7LocDatL > Gx_date ) )
            {
               GXutil.msg( me(), "Não é possível consultar locações futuras!" );
            }
         }
      }

      public void loadToBuffer10( )
      {
         subwpelocacao10 oAux = subwpelocacao10 ;
         subwpelocacao10 = new subwpelocacao10 ();
         variablesToSubfile10 ();
         subGxsf10.addElement(subwpelocacao10);
         subwpelocacao10 = oAux;
      }

      private void E11V262( )
      {
         AV9Marcado = "" ;
         /* Load Routine */
         AV15Editar = "c:\\KB\\DATA002\\bin\\editIcon.jpg" ;
         AV16Visual = "c:\\KB\\DATA002\\bin\\visualizarIcon.jpg" ;
         subGxsf10.loadCommand();
      }

      protected void closeCursors10( )
      {
         pr_default.close(0);
      }

      protected void E14V262( )
      {
         eventLevelContext();
         /* 'Novo' Routine */
         new tlocacao(context, base.remoteHandle, base.context).execute(  0,  "INS") ;
         GXRefresh();
      }

      protected void E15V262( )
      {
         eventLevelContext();
         /* 'Marcado' Routine */
         for (java.util.Enumeration en0 = subGxsf10.elements(); en0.hasMoreElements();)
         {
            subwpelocacao10 = (subwpelocacao10) en0.nextElement();
            subfileToVariables10 ();
            AV9Marcado = "S" ;
            variablesToSubfile10 ();
            subGxsf10.refreshLineValueFEL(subwpelocacao10);
         }
         eventLevelContext( );
      }

      protected void E16V262( )
      {
         eventLevelContext();
         /* 'Desmarcado' Routine */
         for (java.util.Enumeration en1 = subGxsf10.elements(); en1.hasMoreElements();)
         {
            subwpelocacao10 = (subwpelocacao10) en1.nextElement();
            subfileToVariables10 ();
            AV9Marcado = "N" ;
            variablesToSubfile10 ();
            subGxsf10.refreshLineValueFEL(subwpelocacao10);
         }
         eventLevelContext( );
      }

      protected void E17V262( )
      {
         eventLevelContext();
         /* 'RealizarDevolver' Routine */
         for (java.util.Enumeration en2 = subGxsf10.elements(); en2.hasMoreElements();)
         {
            subwpelocacao10 = (subwpelocacao10) en2.nextElement();
            subfileToVariables10 ();
            if ( ( String.CompareOrdinal(AV9Marcado.TrimEnd(' '), "S".TrimEnd(' ') ) == 0 ) )
            {
               AV10AtzLoc = 1 ;
               new patzlocacao(context, base.remoteHandle, base.context).execute(  AV12Y, ref  A86LocCodi,  AV10AtzLoc, ref  A87LocSitu, out  AV17MsgErr) ;
               n87LocSitu = false ;
               if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV17MsgErr).TrimEnd(' ') )==0)) )
               {
                  GXutil.msg( me(), AV17MsgErr );
               }
            }
            variablesToSubfile10 ();
            subGxsf10.refreshLineValueFEL(subwpelocacao10);
         }
         eventLevelContext( );
         GXRefresh();
      }

      protected void E18V262( )
      {
         eventLevelContext();
         /* 'CancelarExcluir' Routine */
         for (java.util.Enumeration en3 = subGxsf10.elements(); en3.hasMoreElements();)
         {
            subwpelocacao10 = (subwpelocacao10) en3.nextElement();
            subfileToVariables10 ();
            if ( ( String.CompareOrdinal(AV9Marcado.TrimEnd(' '), "S".TrimEnd(' ') ) == 0 ) )
            {
               AV10AtzLoc = 2 ;
               new patzlocacao(context, base.remoteHandle, base.context).execute(  AV12Y, ref  A86LocCodi,  AV10AtzLoc, ref  A87LocSitu, out  AV17MsgErr) ;
               n87LocSitu = false ;
            }
            variablesToSubfile10 ();
            subGxsf10.refreshLineValueFEL(subwpelocacao10);
         }
         eventLevelContext( );
         GXRefresh();
      }

      protected void E19V262( )
      {
         eventLevelContext();
         /* 'AcessoPelaGrid' Routine */
         if ( ( A87LocSitu == 1 ) )
         {
            new tlocacao(context, base.remoteHandle, base.context).execute(  A86LocCodi,  "UPD") ;
         }
         else if ( ( A87LocSitu != 1 ) )
         {
            new tlocacao(context, base.remoteHandle, base.context).execute(  A86LocCodi,  "DSP") ;
         }
         GXRefresh();
      }

      protected void E20V262( )
      {
         eventLevelContext();
         /* Visualizar_Click Routine */
         if ( ( A87LocSitu != 1 ) )
         {
            new tlocacao(context, base.remoteHandle, base.context).execute(  A86LocCodi,  "DSP") ;
         }
         else
         {
            GXutil.msg( me(), "Não é possível visualizar esta locação!" );
         }
         eventLevelResetContext();
      }

      protected void E21V262( )
      {
         eventLevelContext();
         /* Editar_Click Routine */
         if ( ( A87LocSitu == 1 ) )
         {
            new tlocacao(context, base.remoteHandle, base.context).execute(  A86LocCodi,  "UPD") ;
         }
         else
         {
            GXutil.msg( me(), "Não é possível editar esta locação!" );
         }
         eventLevelResetContext();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 910 , 832 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavLocclipescodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),65, 71, 78, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 65 , 71 , 78 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5LocCliP" );
         ((GXEdit) edtavLocclipescodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavLocclipescodigo.addFocusListener(this);
         edtavLocclipescodigo.getGXComponent().setHelpId("HLP_WPeLocacao.htm");
         edtavLocclipesnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),156, 71, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 156 , 71 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6LocCliP" );
         ((GXEdit) edtavLocclipesnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavLocclipesnome.addFocusListener(this);
         edtavLocclipesnome.getGXComponent().setHelpId("HLP_WPeLocacao.htm");
         edtavLocdatlocacao = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),65, 117, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 65 , 117 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7LocDatL" );
         ((GXEdit) edtavLocdatlocacao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavLocdatlocacao.addFocusListener(this);
         edtavLocdatlocacao.getGXComponent().setHelpId("HLP_WPeLocacao.htm");
         cmbavLocsituacao = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 156 , 117 , 117 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8LocSitu" );
         ((GXComboBox) cmbavLocsituacao.getGXComponent()).addItem( new java.lang.Short(0),"Todas");
         ((GXComboBox) cmbavLocsituacao.getGXComponent()).addItem( new java.lang.Short(1),"Digitada");
         ((GXComboBox) cmbavLocsituacao.getGXComponent()).addItem( new java.lang.Short(2),"Realizada");
         ((GXComboBox) cmbavLocsituacao.getGXComponent()).addItem( new java.lang.Short(3),"Devolvida");
         ((GXComboBox) cmbavLocsituacao.getGXComponent()).addItem( new java.lang.Short(4),"Cancelada");
         cmbavLocsituacao.addFocusListener(this);
         cmbavLocsituacao.addItemListener(this);
         cmbavLocsituacao.getGXComponent().setHelpId("HLP_WPeLocacao.htm");
         addSubfile ( subGxsf10  = new GXSubfile ( new PeLocacao_load10(this), new PeLocacao_flow10(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectString ( new GXCheckBox(GXPanel1, "" , "S", "N") , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9Marcado" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 25 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV16Visual" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 25 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 25 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV15Editar" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 25 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 71, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 70 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A86LocCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 70 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 78, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 77 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A88LocDatL" ), "Data"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 77 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 120, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 119 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A91LocCliP" ), "Código do locatário"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 119 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 409, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 408 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A92LocCliP" ), "Locatário"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 408 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 86 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A87LocSitu" ), "Situação"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 86 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 33 , 18 , GXPanel1 , 65 , 169 , 780 , 611 ,  18 ));
         ((GXComboBox) subGxsf10.getColumn(7).getGXComponent()).addItem( new java.lang.Short(1),"Digitada");
         ((GXComboBox) subGxsf10.getColumn(7).getGXComponent()).addItem( new java.lang.Short(2),"Realizada");
         ((GXComboBox) subGxsf10.getColumn(7).getGXComponent()).addItem( new java.lang.Short(3),"Devolvida");
         ((GXComboBox) subGxsf10.getColumn(7).getGXComponent()).addItem( new java.lang.Short(4),"Cancelada");
         subGxsf10.addActionListener(this);
         subGxsf10.addFocusListener(this);
         subGxsf10.setSortOnClick(true);
         subGxsf10.getColumn(1).addActionListener( this);
         subGxsf10.getColumn(1).addItemListener( this);
         subGxsf10.getColumn(2).addActionListener( this);
         subGxsf10.getColumn(2).addItemListener( this);
         bttbtt19 = UIFactory.getGXButton( GXPanel1 , "Novo" ,  739 ,  115 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt19.setTooltip("Novo");
         bttbtt19.addActionListener(this);
         bttbtt19.setFiresEvents(false);
         bttbtt20 = UIFactory.getGXButton( GXPanel1 , "M" ,  117 ,  793 ,  26 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt20.setTooltip("M");
         bttbtt20.addActionListener(this);
         bttbtt20.setFiresEvents(false);
         bttbtt21 = UIFactory.getGXButton( GXPanel1 , "D" ,  156 ,  793 ,  26 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt21.setTooltip("D");
         bttbtt21.addActionListener(this);
         bttbtt21.setFiresEvents(false);
         bttbtt22 = UIFactory.getGXButton( GXPanel1 , "Realizar/Devolver" ,  598 ,  793 ,  104 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt22.setTooltip("Realizar/Devolver");
         bttbtt22.addActionListener(this);
         bttbtt22.setFiresEvents(false);
         bttbtt23 = UIFactory.getGXButton( GXPanel1 , "Cancelar/Excluir" ,  715 ,  793 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt23.setTooltip("Cancelar/Excluir");
         bttbtt23.addActionListener(this);
         bttbtt23.setFiresEvents(false);
         lbllbl6 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 52 , 40 , 13 );
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Nome", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 156 , 52 , 33 , 13 );
         lbllbl8 = UIFactory.getLabel(GXPanel1, "Data", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 101 , 28 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Situação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 156 , 101 , 51 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavLocclipescodigo ,
                   edtavLocclipesnome ,
                   edtavLocdatlocacao ,
                   cmbavLocsituacao ,
                   subGxsf10 ,
                   bttbtt19 ,
                   bttbtt20 ,
                   bttbtt21 ,
                   bttbtt22 ,
                   bttbtt23
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf10, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile10( )
      {
         subwpelocacao10.setVMarcado(AV9Marcado);
         subwpelocacao10.setVVisualizar(AV16Visual);
         subwpelocacao10.setVEditar(AV15Editar);
         subwpelocacao10.setLocCodigo(A86LocCodi);
         subwpelocacao10.setLocDatLocacao(A88LocDatL);
         subwpelocacao10.setLocCliPesCodigo(A91LocCliP);
         subwpelocacao10.setLocCliPesNome(A92LocCliP);
         subwpelocacao10.setLocSituacao(A87LocSitu);
      }

      protected void subfileToVariables10( )
      {
         AV9Marcado = subwpelocacao10.getVMarcado();
         AV16Visual = subwpelocacao10.getVVisualizar();
         AV15Editar = subwpelocacao10.getVEditar();
         A86LocCodi = subwpelocacao10.getLocCodigo();
         A88LocDatL = subwpelocacao10.getLocDatLocacao();
         A91LocCliP = subwpelocacao10.getLocCliPesCodigo();
         A92LocCliP = subwpelocacao10.getLocCliPesNome();
         A87LocSitu = subwpelocacao10.getLocSituacao();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavLocclipescodigo.setValue( AV5LocCliP );
         edtavLocclipesnome.setValue( AV6LocCliP );
         edtavLocdatlocacao.setValue( AV7LocDatL );
         cmbavLocsituacao.setValue( AV8LocSitu );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5LocCliP = (int)(edtavLocclipescodigo.getValue()) ;
         edtavLocclipescodigo.setValue(AV5LocCliP);
         AV6LocCliP = (String)(edtavLocclipesnome.getValue()) ;
         edtavLocclipesnome.setValue(AV6LocCliP);
         AV7LocDatL = (DateTime)(edtavLocdatlocacao.getValue()) ;
         edtavLocdatlocacao.setValue(AV7LocDatL);
         AV8LocSitu = (short)(cmbavLocsituacao.getValue()) ;
         cmbavLocsituacao.setValue(AV8LocSitu);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf10.inValidElement() )
         {
            subwpelocacao10 = ( subwpelocacao10 ) subGxsf10.getCurrentElement() ;
         }
         else
         {
            subwpelocacao10 = new subwpelocacao10 ();
         }
         subfileToVariables10 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile10 ();
         subGxsf10.refreshLineValue(subwpelocacao10);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf10.inValidElement() )
         {
            subwpelocacao10 = ( subwpelocacao10 ) subGxsf10.getCurrentElement() ;
         }
         else
         {
            subwpelocacao10 = new subwpelocacao10 ();
         }
         subfileToVariables10 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttbtt19.isEventSource(eventSource) ) {
            /* Execute user event: E14V262 */
            E14V262 ();
            return;
         }
         if ( bttbtt20.isEventSource(eventSource) ) {
            /* Execute user event: E15V262 */
            E15V262 ();
            return;
         }
         if ( bttbtt21.isEventSource(eventSource) ) {
            /* Execute user event: E16V262 */
            E16V262 ();
            return;
         }
         if ( bttbtt22.isEventSource(eventSource) ) {
            /* Execute user event: E17V262 */
            E17V262 ();
            return;
         }
         if ( bttbtt23.isEventSource(eventSource) ) {
            /* Execute user event: E18V262 */
            E18V262 ();
            return;
         }
         if ( subGxsf10.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf10.getColumn(1).isEventSource(eventSource) ) {
            /* Execute user event: E20V262 */
            E20V262 ();
            return;
         }
         if ( subGxsf10.getColumn(2).isEventSource(eventSource) ) {
            /* Execute user event: E21V262 */
            E21V262 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavLocclipescodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavLocclipescodigo.getGXCursor() );
            return;
         }
         if ( edtavLocclipesnome.isEventSource(eventSource) ) {
            setGXCursor( edtavLocclipesnome.getGXCursor() );
            return;
         }
         if ( edtavLocdatlocacao.isEventSource(eventSource) ) {
            setGXCursor( edtavLocdatlocacao.getGXCursor() );
            return;
         }
         if ( cmbavLocsituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbavLocsituacao.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtavLocclipescodigo.isEventSource(eventSource) ) {
            AV5LocCliP = edtavLocclipescodigo.getValue() ;
            return;
         }
         if ( edtavLocclipesnome.isEventSource(eventSource) ) {
            AV6LocCliP = edtavLocclipesnome.getValue() ;
            return;
         }
         if ( edtavLocdatlocacao.isEventSource(eventSource) ) {
            AV7LocDatL = edtavLocdatlocacao.getValue() ;
            return;
         }
         if ( cmbavLocsituacao.isEventSource(eventSource) ) {
            AV8LocSitu = cmbavLocsituacao.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf10.getColumn(1).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E20V262 */
            E20V262 ();
            return;
         }
         if ( subGxsf10.getColumn(2).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E21V262 */
            E21V262 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E19V262 */
            E19V262 ();
            return true ;
         }
         if (triggerEventEnter(eventSource, keyCode)) {
            return true ;
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
         }
         stopThreads();
         CloseOpenCursors();
         base.cleanup();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         com.genexus.Application.cleanup( base.context , this, remoteHandle);
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         subwpelocacao10 = new subwpelocacao10();
         scmdbuf = "" ;
         AV5LocCliP = 0 ;
         AV6LocCliP = "" ;
         AV7LocDatL = (DateTime)(DateTime.MinValue) ;
         AV8LocSitu = 0 ;
         A91LocCliP = 0 ;
         A92LocCliP = "" ;
         A88LocDatL = (DateTime)(DateTime.MinValue) ;
         A87LocSitu = 0 ;
         W00262_A87LocSitu = new short[1] ;
         W00262_n87LocSitu = new bool[] {false} ;
         W00262_A92LocCliP = new String[] {""} ;
         W00262_n92LocCliP = new bool[] {false} ;
         W00262_A91LocCliP = new int[1] ;
         W00262_n91LocCliP = new bool[] {false} ;
         W00262_A88LocDatL = new DateTime[] {DateTime.MinValue} ;
         W00262_n88LocDatL = new bool[] {false} ;
         W00262_A86LocCodi = new int[1] ;
         n87LocSitu = false ;
         n92LocCliP = false ;
         n91LocCliP = false ;
         n88LocDatL = false ;
         A86LocCodi = 0 ;
         gxIsRefreshing = false ;
         returnInSub = false ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         AV9Marcado = "" ;
         AV15Editar = "" ;
         AV16Visual = "" ;
         AV10AtzLoc = 0 ;
         AV12Y = 0 ;
         AV17MsgErr = "" ;
         Gx_date = DateTimeUtil.Today( ) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wpelocacao__default(),
            new Object[][] {
                new Object[] {
               W00262_A87LocSitu, W00262_n87LocSitu, W00262_A92LocCliP, W00262_n92LocCliP, W00262_A91LocCliP, W00262_n91LocCliP, W00262_A88LocDatL, W00262_n88LocDatL, W00262_A86LocCodi
               }
            }
         );
         reloadDynamicLists(0);
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      protected short AV8LocSitu ;
      protected short A87LocSitu ;
      protected short AV10AtzLoc ;
      protected short AV12Y ;
      protected int AV5LocCliP ;
      protected int A91LocCliP ;
      protected int A86LocCodi ;
      protected String scmdbuf ;
      protected String AV9Marcado ;
      protected DateTime AV7LocDatL ;
      protected DateTime A88LocDatL ;
      protected DateTime Gx_date ;
      protected bool n87LocSitu ;
      protected bool n92LocCliP ;
      protected bool n91LocCliP ;
      protected bool n88LocDatL ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected String AV6LocCliP ;
      protected String A92LocCliP ;
      protected String AV17MsgErr ;
      protected String AV15Editar ;
      protected String AV16Visual ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwpelocacao10 subwpelocacao10 ;
      protected IDataReader W00262 ;
      protected IDataStoreProvider pr_default ;
      protected short[] W00262_A87LocSitu ;
      protected bool[] W00262_n87LocSitu ;
      protected String[] W00262_A92LocCliP ;
      protected bool[] W00262_n92LocCliP ;
      protected int[] W00262_A91LocCliP ;
      protected bool[] W00262_n91LocCliP ;
      protected DateTime[] W00262_A88LocDatL ;
      protected bool[] W00262_n88LocDatL ;
      protected int[] W00262_A86LocCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavLocclipescodigo ;
      protected GUIObjectString edtavLocclipesnome ;
      protected GUIObjectDatetime edtavLocdatlocacao ;
      protected GUIObjectShort cmbavLocsituacao ;
      protected GXSubfile subGxsf10 ;
      protected IGXButton bttbtt19 ;
      protected IGXButton bttbtt20 ;
      protected IGXButton bttbtt21 ;
      protected IGXButton bttbtt22 ;
      protected IGXButton bttbtt23 ;
      protected ILabel lbllbl6 ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl8 ;
      protected ILabel lbllbl9 ;
   }

   public class wpelocacao__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W00262( int AV5LocCliP ,
                                           String AV6LocCliP ,
                                           DateTime AV7LocDatL ,
                                           short AV8LocSitu ,
                                           int A91LocCliP ,
                                           String A92LocCliP ,
                                           DateTime A88LocDatL ,
                                           short A87LocSitu )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT T1.[LocSituacao], T2.[PesNome] AS LocCliPesNome, T1.[LocCliPesCodigo] AS LocCliPesCodigo, T1.[LocDatLocacao], T1.[LocCodigo] FROM ([LOCACAO] T1 WITH (NOLOCK) LEFT JOIN [PESSOA] T2 WITH (NOLOCK) ON T2.[PesCodigo] = T1.[LocCliPesCodigo])" ;
         sWhereString = "" ;
         if ( ( AV5LocCliP != 0 ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[LocCliPesCodigo] = " + StringUtil.Str( (decimal)(AV5LocCliP), 9, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[LocCliPesCodigo] = " + StringUtil.Str( (decimal)(AV5LocCliP), 9, 0) + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV6LocCliP).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T2.[PesNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6LocCliP, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PesNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6LocCliP, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ! ( AV7LocDatL == DateTimeUtil.CToD( "0", 2) ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[LocDatLocacao] = " + ((AV7LocDatL>DateTimeUtil.CToD( "01/01/1753", 3)) ? "convert( DATETIME,'"+DateTimeUtil.DToC( AV7LocDatL, 0, "-")+"',102)" : "convert( DATETIME, '17530101', 112 )") + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[LocDatLocacao] = " + ((AV7LocDatL>DateTimeUtil.CToD( "01/01/1753", 3)) ? "convert( DATETIME,'"+DateTimeUtil.DToC( AV7LocDatL, 0, "-")+"',102)" : "convert( DATETIME, '17530101', 112 )") + ")" ;
            }
         }
         if ( ( AV8LocSitu > 0 ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[LocSituacao] = " + StringUtil.Str( (decimal)(AV8LocSitu), 1, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[LocSituacao] = " + StringUtil.Str( (decimal)(AV8LocSitu), 1, 0) + ")" ;
            }
         }
         if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[LocCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W00262( (int)dynConstraints[0] , (String)dynConstraints[1] , (DateTime)dynConstraints[2] , (short)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] , (DateTime)dynConstraints[6] , (short)dynConstraints[7] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmW00262 ;
          prmW00262 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W00262", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW00262,26,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((int[]) buf[4])[0] = rslt.getInt(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
