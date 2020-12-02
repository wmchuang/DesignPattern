# 模式分类

- 创建型 设计到将对象实例化，这类模式都提供一个方法，将客户从所需要实例化的对象中解耦。
    1. Singleton(单例模式)
    2. Builder(建造者模式)
    3. Prototype(原型模式)
    4. Factory Method(工厂模式)
    5. Abstract Factory(抽象工厂模式)
- 结构型 可以让你把类或对象组合到更大的结构中
    1. Adapter(适配器模式)
    2. Bridge(桥接模式)
    3. Proxy(代理模式)
    4. Decorator(装饰模式)
    5. Flyweight(享元模式)
    6. Composite(组合模式)
    7. Facade(外观模式)
- 行为型 设计到来和对象如何交互及分配职责
    1. ChainOfResponsibility(职责链模式)
    2. Command(命令模式)
    3. Interpreter(解释器模式)
    4. Iterator(迭代器模式)
    5. Observer(观察者模式)
    6. State(状态模式)
    7. Strategy(策略模式)
    8. Visitor(访问者模式)
    9. Template(模板方法模式)
    10.Memento(备忘录模式)
    11.Mediator(中介者模式)
------------
- 类模式   描述类之间的关系如何通过继承定义。类模式的关系实在编译时建立的
- 对象模式 描述对象之间的关系，而且主要是利用组合定义。对象模式的关系通常在运行时建立，而且更加动态、更有弹性

# 设计原则 - HeadFirst
- 找出应用中可能需要变化之处，把他们独立出来,不要和那些不需要变化的代码混在一起
- 针对接口编程而不是针对实现编程
- 多用组合，少用继承
- 为了交互对象之间的松耦合而努力
- 类的设计应该对拓展开放，对修改关闭
- 依赖倒置原则：要依赖抽象，不要依赖具体类。高层次的模块不应该依赖于低层次的模块
- 最少知识原则
- 好莱坞原则：别调用我们，我们会调用你
- 一个类应该只有一个引起变化的原因

## 要点总结
- 接口做为参数传递，传递的是实现了接口的对象
- 接口作为类型返回，返回的是实现了接口的对象
- 里氏代换原则： 任何基类可以出现的地方，子类一定可以出现
- 设计模式的本质就是一句话：将软件中变化的部分和不变的部分分开