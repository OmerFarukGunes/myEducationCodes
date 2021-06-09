class CustomerManager implements ICustomer {
  @override //bu lekilde interface impleme edilebilir.
  void Save(ILogger logger) {
    print("kaydedildi");
    EmailLogger emailLogger = new EmailLogger();
    logger.Log("log datası");
    //bu şekilde yapınca artık hangi türden logger gönderirsen onun logu gelir.
  }
}

//dartta interface yok direkt class yazılır
class ICustomer {
  void Save(ILogger logger) {}
}

class ILogger {
  void Log(String Message) {}
}

class EmailLogger implements ILogger {
  @override
  void Log(String Message) {
    print("email logger" + Message);
  }
}

class PhonelLogger implements ILogger {
  @override
  void Log(String Message) {
    print("Phone logger" + Message);
  }
}

void main() {
  CustomerManager customerManager = new CustomerManager();
  customerManager.Save(new EmailLogger());
}
