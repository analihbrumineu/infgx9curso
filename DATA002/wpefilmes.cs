/*
               File: PeFilmes
        Description: Cadastro de filmes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 4/10/2026 9:12:10.5
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
   public class wpefilmes : GXWorkpanel
   {
      public wpefilmes( int hnd ,
                        ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wpefilmes( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wpefilmes( IGxContext context ,
                        int hnd ,
                        ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "PeFilmes" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de filmes." ;
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
         return 1001 ;
      }

      public override int getFrmHeight( )
      {
         return 741 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WPeFilmes.htm";
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
         GXV_CATNOME_htmlV0D2( ) ;
      }

      public void runLoad_load02( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwpefilmes02 = new subwpefilmes02 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV8FilCodi ,
                                              AV11FilNom ,
                                              AV9FilData ,
                                              AV7CatNome ,
                                              A28FilCodi ,
                                              A29FilNome ,
                                              A31FilData ,
                                              A33CatNome },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W000D2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf2.getSize() < 10000 ) ) )
         {
            A32CatCodi = W000D2_A32CatCodi[0] ;
            n32CatCodi = W000D2_n32CatCodi[0] ;
            A30FilSitu = W000D2_A30FilSitu[0] ;
            n30FilSitu = W000D2_n30FilSitu[0] ;
            A33CatNome = W000D2_A33CatNome[0] ;
            n33CatNome = W000D2_n33CatNome[0] ;
            A31FilData = W000D2_A31FilData[0] ;
            n31FilData = W000D2_n31FilData[0] ;
            A29FilNome = W000D2_A29FilNome[0] ;
            n29FilNome = W000D2_n29FilNome[0] ;
            A28FilCodi = W000D2_A28FilCodi[0] ;
            A33CatNome = W000D2_A33CatNome[0] ;
            n33CatNome = W000D2_n33CatNome[0] ;
            /* Execute user event: E11V0D2 */
            E11V0D2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf2.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class PeFilmes_load02 : GXLoadProducer
      {
         wpefilmes _sf ;

         public PeFilmes_load02( wpefilmes uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer02();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load02();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors02();
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
            subGxsf2.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow02( )
      {
         return true;
      }

      public void autoRefresh_flow02( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow02() )) {
            subfile.refresh();
            resetSubfileConditions_flow02() ;
         }
      }

      public bool getSearch_flow02( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow02( )
      {
      }

      public void resetSearchConditions_flow02( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow02( )
      {
         return new subwpefilmes02 ();
      }

      public bool getSearch_flow02( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow02( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow02( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow02( )
      {
         GXRefreshCommand02 ();
      }

      public class PeFilmes_flow02 : GXSubfileFlow
      {
         wpefilmes _sf ;

         public PeFilmes_flow02( wpefilmes uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow02();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow02(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow02();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow02();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow02(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow02();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow02(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow02(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow02(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow02();
         }

      }

      protected void GXRefreshCommand02( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public void loadToBuffer02( )
      {
         subwpefilmes02 oAux = subwpefilmes02 ;
         subwpefilmes02 = new subwpefilmes02 ();
         variablesToSubfile02 ();
         subGxsf2.addElement(subwpefilmes02);
         subwpefilmes02 = oAux;
      }

      private void E11V0D2( )
      {
         /* Load Routine */
         AV6Excluir = "C:\\KB\\DATA002\\bin\\deleteIcon.jpg" ;
         AV5Editar = "C:\\KB\\DATA002\\bin\\editIcon.jpg" ;
         subGxsf2.loadCommand();
      }

      protected void closeCursors02( )
      {
         pr_default.close(0);
      }

      protected void E12V0D2( )
      {
         eventLevelContext();
         /* Editar_Click Routine */
         new tfilme(context, base.remoteHandle, base.context).execute(  A28FilCodi,  "UPD") ;
         GXRefresh();
      }

      protected void E13V0D2( )
      {
         eventLevelContext();
         /* Excluir_Click Routine */
         new tfilme(context, base.remoteHandle, base.context).execute(  A28FilCodi,  "DLT") ;
         GXRefresh();
      }

      protected void E14V0D2( )
      {
         eventLevelContext();
         /* 'Novo' Routine */
         new tfilme(context, base.remoteHandle, base.context).execute(  0,  "INS") ;
         GXRefresh();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 1001 , 741 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavFilcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),65, 39, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 65 , 39 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8FilCodi" );
         ((GXEdit) edtavFilcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavFilcodigo.addFocusListener(this);
         edtavFilcodigo.getGXComponent().setHelpId("HLP_WPeFilmes.htm");
         edtavFilnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),156, 39, 273, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 156 , 39 , 273 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV11FilNom" );
         ((GXEdit) edtavFilnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavFilnome.addFocusListener(this);
         edtavFilnome.getGXComponent().setHelpId("HLP_WPeFilmes.htm");
         edtavFildata = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),442, 39, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 442 , 39 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9FilData" );
         ((GXEdit) edtavFildata.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavFildata.addFocusListener(this);
         edtavFildata.getGXComponent().setHelpId("HLP_WPeFilmes.htm");
         dynavCatnome = new GUIObjectString ( new GXComboBox(GXPanel1, this, 12) , GXPanel1 , 533 , 39 , 273 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7CatNome" );
         dynavCatnome.addFocusListener(this);
         dynavCatnome.addItemListener(this);
         dynavCatnome.getGXComponent().setHelpId("HLP_WPeFilmes.htm");
         addSubfile ( subGxsf2  = new GXSubfile ( new PeFilmes_load02(this), new PeFilmes_flow02(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV6Excluir" ), "Excluir"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 25 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV5Editar" ), "Editar"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 25 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 92, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 91 , 18 , UIFactory.getColor(5) , UIFactory.getColor(255, 0, 0) , UIFactory.getFont( "Courier New", 0, 9) , false , "A28FilCodi" ), "CODF"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 91 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 371, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 370 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A29FilNome" ), "Título"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 370 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 67, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 66 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A31FilData" ), "Estreia"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 66 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 183, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 182 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A33CatNome" ), "Categoria"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 182 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 115 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A30FilSitu" ), "Status"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 115 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 35 , 18 , GXPanel1 , 65 , 78 , 871 , 650 ,  18 ));
         ((GXComboBox) subGxsf2.getColumn(6).getGXComponent()).addItem( new java.lang.Short(1),"Ativo");
         ((GXComboBox) subGxsf2.getColumn(6).getGXComponent()).addItem( new java.lang.Short(2),"Inativo");
         subGxsf2.addActionListener(this);
         subGxsf2.addFocusListener(this);
         subGxsf2.setSortOnClick(true);
         subGxsf2.addItemListener(this);
         subGxsf2.getColumn(0).addActionListener( this);
         subGxsf2.getColumn(0).addItemListener( this);
         subGxsf2.getColumn(1).addActionListener( this);
         subGxsf2.getColumn(1).addItemListener( this);
         bttbtt17 = UIFactory.getGXButton( GXPanel1 , "Novo" ,  845 ,  39 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt17.setTooltip("Novo");
         bttbtt17.addActionListener(this);
         bttbtt17.setFiresEvents(false);
         lbllbl13 = UIFactory.getLabel(GXPanel1, "CODF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 42 , 13 );
         lbllbl14 = UIFactory.getLabel(GXPanel1, "Título", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 156 , 26 , 81 , 14 );
         lbllbl15 = UIFactory.getLabel(GXPanel1, "Estreia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 442 , 26 , 81 , 14 );
         lbllbl16 = UIFactory.getLabel(GXPanel1, "Categoria", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 533 , 26 , 81 , 15 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavFilcodigo ,
                   edtavFilnome ,
                   edtavFildata ,
                   dynavCatnome ,
                   subGxsf2 ,
                   bttbtt17
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf2, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile02( )
      {
         subwpefilmes02.setVExcluir(AV6Excluir);
         subwpefilmes02.setVEditar(AV5Editar);
         subwpefilmes02.setFilCodigo(A28FilCodi);
         subwpefilmes02.setFilNome(A29FilNome);
         subwpefilmes02.setFilData(A31FilData);
         subwpefilmes02.setCatNome(A33CatNome);
         subwpefilmes02.setFilSituacao(A30FilSitu);
      }

      protected void subfileToVariables02( )
      {
         AV6Excluir = subwpefilmes02.getVExcluir();
         AV5Editar = subwpefilmes02.getVEditar();
         A28FilCodi = subwpefilmes02.getFilCodigo();
         A29FilNome = subwpefilmes02.getFilNome();
         A31FilData = subwpefilmes02.getFilData();
         A33CatNome = subwpefilmes02.getCatNome();
         A30FilSitu = subwpefilmes02.getFilSituacao();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavFilnome.setValue( AV11FilNom );
         edtavFildata.setValue( AV9FilData );
         dynavCatnome.setValue( AV7CatNome );
         edtavFilcodigo.setValue( AV8FilCodi );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV11FilNom = (String)(edtavFilnome.getValue()) ;
         edtavFilnome.setValue(AV11FilNom);
         AV9FilData = (DateTime)(edtavFildata.getValue()) ;
         edtavFildata.setValue(AV9FilData);
         AV7CatNome = (String)(dynavCatnome.getValue()) ;
         dynavCatnome.setValue(AV7CatNome);
         AV8FilCodi = (int)(edtavFilcodigo.getValue()) ;
         edtavFilcodigo.setValue(AV8FilCodi);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf2.inValidElement() )
         {
            subwpefilmes02 = ( subwpefilmes02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwpefilmes02 = new subwpefilmes02 ();
         }
         subfileToVariables02 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile02 ();
         subGxsf2.refreshLineValue(subwpefilmes02);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf2.inValidElement() )
         {
            subwpefilmes02 = ( subwpefilmes02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwpefilmes02 = new subwpefilmes02 ();
         }
         subfileToVariables02 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttbtt17.isEventSource(eventSource) ) {
            /* Execute user event: E14V0D2 */
            E14V0D2 ();
            return;
         }
         if ( subGxsf2.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E13V0D2 */
            E13V0D2 ();
            return;
         }
         if ( subGxsf2.getColumn(1).isEventSource(eventSource) ) {
            /* Execute user event: E12V0D2 */
            E12V0D2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavFilnome.isEventSource(eventSource) ) {
            setGXCursor( edtavFilnome.getGXCursor() );
            return;
         }
         if ( edtavFildata.isEventSource(eventSource) ) {
            setGXCursor( edtavFildata.getGXCursor() );
            return;
         }
         if ( dynavCatnome.isEventSource(eventSource) ) {
            setGXCursor( dynavCatnome.getGXCursor() );
            return;
         }
         if ( edtavFilcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavFilcodigo.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) ) {
            GXV_CATNOME_htmlV0D2( ) ;
            VariablesToControls();
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtavFilnome.isEventSource(eventSource) ) {
            AV11FilNom = edtavFilnome.getValue() ;
            return;
         }
         if ( edtavFildata.isEventSource(eventSource) ) {
            AV9FilData = edtavFildata.getValue() ;
            return;
         }
         if ( dynavCatnome.isEventSource(eventSource) ) {
            AV7CatNome = dynavCatnome.getValue() ;
            return;
         }
         if ( edtavFilcodigo.isEventSource(eventSource) ) {
            AV8FilCodi = edtavFilcodigo.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf2.getColumn(1).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E12V0D2 */
            E12V0D2 ();
            return;
         }
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E13V0D2 */
            E13V0D2 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
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

      protected void GXV_CATNOME_htmlV0D2( )
      {
         String gxdynajaxvalue ;
         GXDLV_CATNOME_dataV0D2( ) ;
         gxdynajaxindex = 1 ;
         while ( ( gxdynajaxindex <= gxdynajaxctrlcodr.Count ) )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            ((GXComboBox) dynavCatnome.getGXComponent()).addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), (short)(gxdynajaxindex));
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         ((GXComboBox) dynavCatnome.getGXComponent()).removeAllItemsFrom(gxdynajaxindex);
      }

      protected void GXDLV_CATNOME_dataV0D2( )
      {
         /* Using cursor W000D3 */
         pr_default.execute(1);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("Selecione uma categoria.");
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( W000D3_A33CatNome[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( W000D3_A33CatNome[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
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
         subwpefilmes02 = new subwpefilmes02();
         scmdbuf = "" ;
         AV8FilCodi = 0 ;
         AV11FilNom = "" ;
         AV9FilData = (DateTime)(DateTime.MinValue) ;
         AV7CatNome = "" ;
         A28FilCodi = 0 ;
         A29FilNome = "" ;
         A31FilData = (DateTime)(DateTime.MinValue) ;
         A33CatNome = "" ;
         W000D2_A32CatCodi = new int[1] ;
         W000D2_n32CatCodi = new bool[] {false} ;
         W000D2_A30FilSitu = new short[1] ;
         W000D2_n30FilSitu = new bool[] {false} ;
         W000D2_A33CatNome = new String[] {""} ;
         W000D2_n33CatNome = new bool[] {false} ;
         W000D2_A31FilData = new DateTime[] {DateTime.MinValue} ;
         W000D2_n31FilData = new bool[] {false} ;
         W000D2_A29FilNome = new String[] {""} ;
         W000D2_n29FilNome = new bool[] {false} ;
         W000D2_A28FilCodi = new int[1] ;
         A32CatCodi = 0 ;
         n32CatCodi = false ;
         A30FilSitu = 0 ;
         n30FilSitu = false ;
         n33CatNome = false ;
         n31FilData = false ;
         n29FilNome = false ;
         gxIsRefreshing = false ;
         AV6Excluir = "" ;
         AV5Editar = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxindex = 0 ;
         W000D3_A32CatCodi = new int[1] ;
         W000D3_n32CatCodi = new bool[] {false} ;
         W000D3_A33CatNome = new String[] {""} ;
         W000D3_n33CatNome = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wpefilmes__default(),
            new Object[][] {
                new Object[] {
               W000D2_A32CatCodi, W000D2_n32CatCodi, W000D2_A30FilSitu, W000D2_n30FilSitu, W000D2_A33CatNome, W000D2_n33CatNome, W000D2_A31FilData, W000D2_n31FilData, W000D2_A29FilNome, W000D2_n29FilNome,
               W000D2_A28FilCodi
               }
               , new Object[] {
               W000D3_A32CatCodi, W000D3_A33CatNome, W000D3_n33CatNome
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short A30FilSitu ;
      protected int AV8FilCodi ;
      protected int A28FilCodi ;
      protected int A32CatCodi ;
      protected int gxdynajaxindex ;
      protected String scmdbuf ;
      protected DateTime AV9FilData ;
      protected DateTime A31FilData ;
      protected bool n32CatCodi ;
      protected bool n30FilSitu ;
      protected bool n33CatNome ;
      protected bool n31FilData ;
      protected bool n29FilNome ;
      protected bool gxIsRefreshing ;
      protected String AV11FilNom ;
      protected String AV7CatNome ;
      protected String A29FilNome ;
      protected String A33CatNome ;
      protected String AV6Excluir ;
      protected String AV5Editar ;
      protected GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      protected GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwpefilmes02 subwpefilmes02 ;
      protected IDataReader W000D2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W000D2_A32CatCodi ;
      protected bool[] W000D2_n32CatCodi ;
      protected short[] W000D2_A30FilSitu ;
      protected bool[] W000D2_n30FilSitu ;
      protected String[] W000D2_A33CatNome ;
      protected bool[] W000D2_n33CatNome ;
      protected DateTime[] W000D2_A31FilData ;
      protected bool[] W000D2_n31FilData ;
      protected String[] W000D2_A29FilNome ;
      protected bool[] W000D2_n29FilNome ;
      protected int[] W000D2_A28FilCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavFilcodigo ;
      protected GUIObjectString edtavFilnome ;
      protected GUIObjectDatetime edtavFildata ;
      protected GUIObjectString dynavCatnome ;
      protected GXSubfile subGxsf2 ;
      protected IGXButton bttbtt17 ;
      protected ILabel lbllbl13 ;
      protected ILabel lbllbl14 ;
      protected ILabel lbllbl15 ;
      protected ILabel lbllbl16 ;
      protected IDataReader W000D3 ;
      protected int[] W000D3_A32CatCodi ;
      protected bool[] W000D3_n32CatCodi ;
      protected String[] W000D3_A33CatNome ;
      protected bool[] W000D3_n33CatNome ;
   }

   public class wpefilmes__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000D2( int AV8FilCodi ,
                                           String AV11FilNom ,
                                           DateTime AV9FilData ,
                                           String AV7CatNome ,
                                           int A28FilCodi ,
                                           String A29FilNome ,
                                           DateTime A31FilData ,
                                           String A33CatNome )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT T1.[CatCodigo], T1.[FilSituacao], T2.[CatNome], T1.[FilData], T1.[FilNome], T1.[FilCodigo] FROM ([FILME] T1 WITH (NOLOCK) LEFT JOIN [CATEGORIA] T2 WITH (NOLOCK) ON T2.[CatCodigo] = T1.[CatCodigo])" ;
         sWhereString = "" ;
         if ( ! ((0==AV8FilCodi)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[FilCodigo] = " + StringUtil.Str( (decimal)(AV8FilCodi), 9, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[FilCodigo] = " + StringUtil.Str( (decimal)(AV8FilCodi), 9, 0) + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV11FilNom).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[FilNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV11FilNom, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[FilNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV11FilNom, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ( AV9FilData != DateTimeUtil.CToD( "0", 2) ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[FilData] = " + ((AV9FilData>DateTimeUtil.CToD( "01/01/1753", 3)) ? "convert( DATETIME,'"+DateTimeUtil.DToC( AV9FilData, 0, "-")+"',102)" : "convert( DATETIME, '17530101', 112 )") + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[FilData] = " + ((AV9FilData>DateTimeUtil.CToD( "01/01/1753", 3)) ? "convert( DATETIME,'"+DateTimeUtil.DToC( AV9FilData, 0, "-")+"',102)" : "convert( DATETIME, '17530101', 112 )") + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV7CatNome).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T2.[CatNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV7CatNome, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " (T2.[CatNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV7CatNome, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[FilCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W000D2( (int)dynConstraints[0] , (String)dynConstraints[1] , (DateTime)dynConstraints[2] , (String)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] , (DateTime)dynConstraints[6] , (String)dynConstraints[7] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmW000D3 ;
          prmW000D3 = new Object[] {
          } ;
          Object[] prmW000D2 ;
          prmW000D2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000D2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000D2,28,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W000D3", "SELECT [CatCodigo], [CatNome] FROM [CATEGORIA] WITH (NOLOCK) ORDER BY [CatNome] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000D3,0,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((int[]) buf[10])[0] = rslt.getInt(6) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
