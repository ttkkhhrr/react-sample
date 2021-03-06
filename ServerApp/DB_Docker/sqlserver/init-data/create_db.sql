sp_configure 'contained database authentication', 1;  
GO  
RECONFIGURE;  
GO  
SET QUOTED_IDENTIFIER ON
GO


CREATE DATABASE owmlocal
CONTAINMENT = PARTIAL -- 包含データベースとして作成。
GO

ALTER DATABASE [owmlocal] SET COMPATIBILITY_LEVEL = 100
GO
ALTER DATABASE [owmlocal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [owmlocal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [owmlocal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [owmlocal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [owmlocal] SET ARITHABORT OFF 
GO
ALTER DATABASE [owmlocal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [owmlocal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [owmlocal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [owmlocal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [owmlocal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [owmlocal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [owmlocal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [owmlocal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [owmlocal] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [owmlocal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [owmlocal] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [owmlocal] SET  MULTI_USER 
GO
ALTER DATABASE [owmlocal] SET QUERY_STORE = ON
GO
ALTER DATABASE [owmlocal] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO)
GO

CREATE LOGIN localuser WITH PASSWORD = 'Passw0rd01!' 
GO


USE owmlocal
GO

DROP USER IF EXISTS localuser 
GO
CREATE USER localuser FOR LOGIN localuser
-- CREATE USER localuser WITH PASSWORD = 'Passw0rd01!' -- InitialCatalog指定なしでログイン出来るようにするためこっちは使わない。 
GO
ALTER ROLE db_ddladmin ADD MEMBER localuser
GO
ALTER ROLE db_datawriter ADD MEMBER localuser
GO
ALTER ROLE db_datareader ADD MEMBER localuser
GO
ALTER ROLE db_backupoperator ADD MEMBER localuser
GO
ALTER ROLE db_owner ADD MEMBER localuser
GO